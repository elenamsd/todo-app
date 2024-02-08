using Microsoft.AspNetCore.Mvc.Testing;

namespace Tests;

public class CustomWebApplicationFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram: class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            
        });
        base.ConfigureWebHost(builder);
    }
}