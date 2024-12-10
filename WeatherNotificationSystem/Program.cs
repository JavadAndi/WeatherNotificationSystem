using System;
using WeatherNotificationSystem.Core;
using WeatherNotificationSystem.Services;

namespace WeatherNotificationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageHandler = new MessageHandler();

            var publisher = new WeatherPublisher(messageHandler);
            var subscriber1 = new WeatherSubscriber(messageHandler, "Subscriber 1");
            var subscriber2 = new WeatherSubscriber(messageHandler, "ُSubscriber 2");

            publisher.PublishWeather("Tehran", "ُSunny with 28 degrees");
            publisher.PublishWeather("Babol", "Rainy with 15 degrees");

            Console.WriteLine("Press Enter for exit...");
            Console.ReadLine();
        }
    }
}
