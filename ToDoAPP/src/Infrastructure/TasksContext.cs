using Microsoft.EntityFrameworkCore;
using ToDoAPP.Domain;

namespace ToDoAPP.Infrastructure;

public class TasksContext: DbContext
{
    
    public TasksContext(DbContextOptions<TasksContext> options)
        : base(options)
    {
    }

    public DbSet<TodoTask> TodoTasks { get; set; } = null!;

}