using Microsoft.Extensions.DependencyInjection;
using proyecto.Loc;

public void ConfigureServices(IServiceCollection services)
{
    services.AddProjectDependencies();
    // otras configuraciones
}