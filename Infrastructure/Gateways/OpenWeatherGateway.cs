namespace Infrastructure.Gateways
{
    using Domain.Abstractions;
    using Domain.Entities;
    public class OpenWeatherGateway : IWeatherProviderGateway
    {

        public WeatherForecast GetWeatherByCityAsync(string city)
        {
            return new WeatherForecast()
            {
                City = city,
                Description = "Sunny",
                Temperature = 12
            };
        }
    }
}