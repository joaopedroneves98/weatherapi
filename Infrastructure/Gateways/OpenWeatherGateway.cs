namespace Infrastructure.Gateways
{
    using Domain.Abstractions;
    using Domain.Entities;

    public class OpenWeatherGateway : IWeatherProviderGateway
    {
        public async Task<WeatherForecast> GetWeatherByCityAsync(string city)
        {
            var client = new OpenMeteo.OpenMeteoClient();

            var response = await client.QueryAsync(city);

            if (response is null)
            {
                throw new ApplicationException("Forecast not available for the provided city.");
            }
            
            return new WeatherForecast()
            {
                City = city,
                Description = WeatherConditions.GetWeatherInfo(response.Current?.Weathercode).Day.Description,
                Temperature = response.Current?.Temperature
            };
        }
    }
}