using Microsoft.Extensions.DependencyInjection;
using proyecto.Ioc;

public void ConfigureServices(IServiceCollection services)
{
    services.AddProjectDependencies();
    // otras configuraciones
}