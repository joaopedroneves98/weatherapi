namespace Application.DependencyInjection
{
    using Implementations;

    using Interfaces;

    using Microsoft.Extensions.DependencyInjection;
    
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IWeatherService, WeatherService>();

            return services;
        }
    }
}