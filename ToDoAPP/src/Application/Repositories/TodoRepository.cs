using ToDoAPP.Domain;

namespace ToDoAPP.Application;

public interface ITodoRepository
{
    public Task<List<TodoTask>> RetrieveAllTasks();

    public TodoTask AddTask(TodoTask task);

    // public void EditTask(string id, TodoTask task);
    //
    // public void RemoveTask(string id);
}