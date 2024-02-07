using Microsoft.EntityFrameworkCore;
using ToDoAPP.Application;
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

    public TodoTask AddTask(TodoTask task)
    {
        _tasksContext.TodoTasks.Add(task);
        _tasksContext.SaveChanges();

        return task;
    }
    
}