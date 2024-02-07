using ToDoAPP.Domain;

namespace ToDoAPP.Application.UseCases;

public class RetrieveAllTodoTask
{
    private readonly ITodoRepository _todoRepository;

    public RetrieveAllTodoTask(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<List<TodoTask>> Handle()
    {
        return await _todoRepository.RetrieveAllTasks();
    }
}