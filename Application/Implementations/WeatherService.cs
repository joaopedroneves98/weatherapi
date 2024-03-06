namespace Application.Implementations
{
    using Domain.Abstractions;
    using Domain.Entities;

    using Interfaces;
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherProviderGateway _weatherProviderGateway;
        
        public WeatherService(IWeatherProviderGateway weatherProviderGateway)
        {
            this._weatherProviderGateway = weatherProviderGateway;
        }

        public Task<WeatherForecast> GetWeatherByCityAsync(string city)
        {
            return this._weatherProviderGateway.GetWeatherByCityAsync(city);
        }
    }
}