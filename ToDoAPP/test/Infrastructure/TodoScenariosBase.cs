namespace ToDoAPP.test.Infrastructure;

public class TodoScenariosBase
{
    public static TodoTestServer CreateServer()
    {
        IWebHostBuilder builder = new WebHostBuilder()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureAppConfiguration((context, configurationBuilder) =>
            {
                configurationBuilder
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.Development.json", optional: false)
                    .AddEnvironmentVariables();
            })
            .UseStartup<Startup>();
    }
}