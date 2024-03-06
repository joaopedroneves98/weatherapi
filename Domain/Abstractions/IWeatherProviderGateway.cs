namespace Domain.Abstractions
{
    using Entities;
    public interface IWeatherProviderGateway
    {
        Task<WeatherForecast> GetWeatherByCityAsync(string city); //No Task for now
    }
}