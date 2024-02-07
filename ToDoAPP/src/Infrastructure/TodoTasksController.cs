using System.Collections;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ToDoAPP.Application;
using ToDoAPP.Application.UseCases;
using ToDoAPP.Application.UseCases.UpdateTask;
using ToDoAPP.Domain;

namespace ToDoAPP.Infrastructure;

[Route("api/[controller]")]
[ApiController]
public class TodoTasksController : ControllerBase
{
    private readonly ITodoRepository _todoRepository;
    private readonly RetrieveAllTodoTask _retrieveAllTodoTask;
    private readonly AddTask _addTask;
    private readonly UpdateTask _updateTask;

    public TodoTasksController(
        ITodoRepository todoRepository, 
        RetrieveAllTodoTask retrieveAllTodoTask, AddTask addTask, UpdateTask updateTask)
    {
        _todoRepository = todoRepository;
        _retrieveAllTodoTask = retrieveAllTodoTask;
        _addTask = addTask;
        _updateTask = updateTask;
    }

    [HttpGet]
    public async Task<ActionResult<RetrieveAllTodoTaskResponse>> GetAllTodoTasks()
    {
        var tasks = await _retrieveAllTodoTask.Handle();
        return tasks;
    }

    [HttpPost]
    public async Task<ActionResult<TodoTask>> AddTask(AddTaskRequest task)
    {
        var addedTask = await _addTask.Execute(task);
        return addedTask;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateTask(string id, UpdateTaskRequest task)
    {
        var updatedTask = await _updateTask.Execute(id, task);
        return updatedTask;
    }
}