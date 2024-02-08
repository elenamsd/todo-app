using Microsoft.AspNetCore.TestHost;
using ToDoAPP.Infrastructure;
using ToDoAPP.Models;

namespace ToDoAPP.test.Infrastructure;

public class TodoTestServer: TestServer
{
    public TodoTestServer(IWebHostBuilder builder) : base(builder)
    {
        TasksContext = Host.Services.GetRequiredService<TasksContext>();
    }
    
    public TasksContext TasksContext { get; set; }
}