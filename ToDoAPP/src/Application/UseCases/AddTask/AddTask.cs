using Microsoft.AspNetCore.Mvc;
using ToDoAPP.Domain;

namespace ToDoAPP.Application.UseCases;

public class AddTask
{
    private readonly ITodoRepository _todoRepository;

    public AddTask(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<TodoTask> Execute(AddTaskRequest task)
    {
        var addedTask = new TodoTask(){Title = task.Title, Description = task.Description, IsCompleted = task.IsCompleted};
        return await _todoRepository.AddTask(addedTask);
    }
    
}