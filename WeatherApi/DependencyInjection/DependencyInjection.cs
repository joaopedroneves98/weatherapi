namespace WeatherApi.DependencyInjection
{
    using Application.DependencyInjection;

    using Infrastructure.DependencyInjection;
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddInfrastructureServices();
            services.AddApplicationServices();
            return services;
        }
    }
}