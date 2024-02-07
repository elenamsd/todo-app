using ToDoAPP.Domain;

namespace ToDoAPP.Application.UseCases;

public class RetrieveAllTodoTaskResponse
{
    public List<TodoTask> data { get; set; }
}