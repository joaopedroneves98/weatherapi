namespace WeatherApi.Controllers
{
    using Domain.Abstractions;

    using Microsoft.AspNetCore.Mvc;
    
    [ApiController]
    [Route("weather")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherProviderGateway _weatherProviderGateway;
        
        public WeatherController(IWeatherProviderGateway weatherProviderGateway)
        {
            this._weatherProviderGateway = weatherProviderGateway;
        }

        [HttpGet]
        public IActionResult GetWeatherForecastByCity([FromQuery] string city)
        {
            var result = this._weatherProviderGateway.GetWeatherByCityAsync(city);

            return this.Ok(result);
        }
    }
}