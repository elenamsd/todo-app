using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ToDoAPP.Application.UseCases.UpdateTask;

public class UpdateTask
{
    private readonly ITodoRepository _todoRepository;

    public UpdateTask(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<ActionResult> Execute(string id, UpdateTaskRequest task)
    {
        return await _todoRepository.EditTask(id, task);
    }

}

