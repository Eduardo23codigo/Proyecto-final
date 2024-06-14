using Microsoft.Extensions.DependencyInjection;
using proyecto.Application;
using proyecto.Domain;
using proyecto.Infrastructure;

namespace proyecto.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectDependencies(this IServiceCollection services)
        {
            services.AddScoped<ISampleRepository, SampleRepository>();
            services.AddScoped<SampleService>();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("YourConnectionString"));

            return services;
        }
    }
}