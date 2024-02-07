namespace ToDoAPP.Application.UseCases;

public class AddTaskRequest
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}