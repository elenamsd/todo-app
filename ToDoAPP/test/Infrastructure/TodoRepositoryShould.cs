using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using ToDoAPP.Application;
using ToDoAPP.Domain;
using ToDoAPP.Infrastructure;
using ToDoAPP.test.Mocks;
using Xunit;

namespace ToDoAPP.test.Infrastructure;

public class TodoRepositoryShould
{
  
    [Fact]
    public void RetrieveAllTheTasks()
    {
        List<TodoTask> list = [];
        // ITodoRepository todoRepository = new InMemoryRepository();
        //
        // var tasks = todoRepository.RetrieveAllTasks();
        //
        // tasks.Should().BeEmpty();
    }
}

// public class FakeTodoRepository : ITodoRepository
// {
//     public IEnumerable<TodoTask> RetrieveAllTasks()
//     {
//         return [];
//     }
// }