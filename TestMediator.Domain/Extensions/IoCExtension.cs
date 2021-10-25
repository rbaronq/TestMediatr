using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using MediatR;
using TestMediator.Domain.Abstractions;
using TestMediator.Domain.Queries;

namespace TestMediator.Domain.Extensions
{
    public static class IoCExtension
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddQueries();
        }

        public static void AddQueries(this IServiceCollection services)
        {
            services.AddScoped<IWeatherQueries, WeatherQueries>();
        }
    }
}
