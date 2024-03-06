namespace Domain.Entities
{
    public class WeatherInfo
    {
        public TimeOfDay Day { get; set; }

        public TimeOfDay Nigth { get; set; }
    }

    public class TimeOfDay
    {
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}