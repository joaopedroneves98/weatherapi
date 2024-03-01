namespace WeatherApi.DependencyInjection
{
    using Infrastructure.DependencyInjection;
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddInfrastructureServices();
            return services;
        }
    }
}