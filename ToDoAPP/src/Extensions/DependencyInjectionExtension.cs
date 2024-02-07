using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using ToDoAPP.Application;
using ToDoAPP.Application.UseCases;
using ToDoAPP.Infrastructure;
using ToDoAPP.Models;

namespace ToDoAPP.Extensions;

public static class DependencyInjectionExtension
{
    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddDbContext<TasksContext>(opt =>
        opt.UseInMemoryDatabase("TodoTasks"));
        services.AddDbContext<TodoContext>(opt =>
            opt.UseInMemoryDatabase("TodoList"));
        services.AddScoped<ITodoRepository, InMemoryRepository>();
        
        return services;
    }

    private static void AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<RetrieveAllTodoTask>();
    }

    public static void AddTodoList(this IServiceCollection services)
    {
        services.AddRepositories().AddUseCases();
    }
}