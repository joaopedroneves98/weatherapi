namespace Infrastructure.DependencyInjection
{
    using Domain.Abstractions;

    using Gateways;

    using Microsoft.Extensions.DependencyInjection;
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IWeatherProviderGateway, OpenWeatherGateway>();

            return services;
        }
    }
}