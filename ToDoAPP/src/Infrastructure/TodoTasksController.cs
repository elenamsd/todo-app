using System.Collections;
using Microsoft.AspNetCore.Mvc;
using ToDoAPP.Application;
using ToDoAPP.Application.UseCases;
using ToDoAPP.Domain;

namespace ToDoAPP.Infrastructure;

[Route("api/[controller]")]
[ApiController]
public class TodoTasksController
{
    private readonly ITodoRepository _todoRepository;
    private readonly RetrieveAllTodoTask _retrieveAllTodoTask;

    public TodoTasksController(
        ITodoRepository todoRepository, 
        RetrieveAllTodoTask retrieveAllTodoTask)
    {
        _todoRepository = todoRepository;
        _retrieveAllTodoTask = retrieveAllTodoTask;
    }

    [HttpGet]
    public async Task<ActionResult<List<TodoTask>>> GetAllTodoTasks()
    {
        var tasks = await _retrieveAllTodoTask.Handle();
        return tasks;
    }

    [HttpPost]
    public ActionResult<TodoTask> AddTask(TodoTask task)
    {
        return new ActionResult<TodoTask>(_todoRepository.AddTask(task));
    }
}