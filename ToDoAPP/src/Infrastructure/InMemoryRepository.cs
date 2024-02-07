using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoAPP.Application;
using ToDoAPP.Application.UseCases.UpdateTask;
using ToDoAPP.Domain;

namespace ToDoAPP.Infrastructure;

public class InMemoryRepository: ITodoRepository
{
    private readonly TasksContext _tasksContext;

    public InMemoryRepository(TasksContext tasksContext)
    {
        _tasksContext = tasksContext;
    }
    
    public async Task<List<TodoTask>> RetrieveAllTasks()
    {
        return await _tasksContext.TodoTasks.ToListAsync();
    }

    public async Task<TodoTask?> RetrieveTaskById(string id)
    {
        return await _tasksContext.TodoTasks.FindAsync(id);
    }

    public async Task<TodoTask> AddTask(TodoTask task)
    {
        _tasksContext.TodoTasks.Add(task);
        await _tasksContext.SaveChangesAsync();

        return task;
    }

    public async Task<ActionResult>  EditTask(string id, UpdateTaskRequest task)
    {
        if (id != task.Id)
        {
            return new BadRequestResult();
        }
        
        var todoItem = await RetrieveTaskById(id);
        
        if (todoItem == null)
        {
            return new NotFoundResult();
        }

        todoItem.Title = task.Title;
        todoItem.Description = task.Description;
        todoItem.IsCompleted = task.IsCompleted;
        
        try
        {
            await _tasksContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TodoItemExists(id))
            {
                return new NotFoundResult();
            }

            throw;
        }

        return new NoContentResult();
    }
    
    private bool TodoItemExists(string id)
    {
        return _tasksContext.TodoTasks.Any(e => e.Id == id);
    }
}