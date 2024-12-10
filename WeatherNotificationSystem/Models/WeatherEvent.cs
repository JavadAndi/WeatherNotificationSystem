namespace WeatherNotificationSystem.Models
{
    public class WeatherEvent
    {
        public string City { get; set; }
        public string Forecast { get; set; }

        public WeatherEvent(string city, string forecast)
        {
            City = city;
            Forecast = forecast;
        }

        public override string ToString()
        {
            return $"{City}: {Forecast}";
        }
    }
}
