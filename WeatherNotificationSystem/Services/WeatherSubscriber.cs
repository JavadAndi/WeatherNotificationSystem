using System;
using WeatherNotificationSystem.Core;
using WeatherNotificationSystem.Models;

namespace WeatherNotificationSystem.Services
{
    public class WeatherSubscriber
    {
        private readonly string _subscriberName;

        public WeatherSubscriber(IMessageHandler messageHandler, string subscriberName)
        {
            _subscriberName = subscriberName;
            messageHandler.Subscribe<WeatherEvent>(OnWeatherReceived);
        }

        private void OnWeatherReceived(WeatherEvent weather)
        {
            Console.WriteLine($"[{_subscriberName}] Recived: {weather}");
        }
    }
}
