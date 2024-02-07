using Microsoft.AspNetCore.Mvc;
using ToDoAPP.Application.UseCases.UpdateTask;
using ToDoAPP.Domain;

namespace ToDoAPP.Application;

public interface ITodoRepository
{
    public Task<List<TodoTask>> RetrieveAllTasks();
    
    public Task<TodoTask?> RetrieveTaskById(string id);

    public Task<TodoTask> AddTask(TodoTask task);
    
    public Task<ActionResult>  EditTask(string id, UpdateTaskRequest task);
    //
    // public void RemoveTask(string id);
}