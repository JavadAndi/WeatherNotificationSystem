using System;
using WeatherNotificationSystem.Core;
using WeatherNotificationSystem.Models;

namespace WeatherNotificationSystem.Services
{
    public class WeatherPublisher
    {
        private readonly IMessageHandler _messageHandler;

        public WeatherPublisher(IMessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }

        public void PublishWeather(string city, string forecast)
        {
            var weatherEvent = new WeatherEvent(city, forecast);
            Console.WriteLine($"[Publisher] Publication: {weatherEvent}");
            _messageHandler.Publish(weatherEvent);
        }
    }
}
