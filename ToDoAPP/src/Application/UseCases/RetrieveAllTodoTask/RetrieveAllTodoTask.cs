using ToDoAPP.Domain;

namespace ToDoAPP.Application.UseCases;

public class RetrieveAllTodoTask
{
    private readonly ITodoRepository _todoRepository;

    public RetrieveAllTodoTask(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<RetrieveAllTodoTaskResponse> Handle()
    {
        var tasks = await _todoRepository.RetrieveAllTasks();
        var response = new RetrieveAllTodoTaskResponse(){data = tasks};
        return response;
    }
}