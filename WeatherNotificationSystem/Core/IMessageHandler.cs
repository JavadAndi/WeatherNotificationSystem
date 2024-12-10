namespace WeatherNotificationSystem.Core
{
    public interface IMessageHandler
    {
        void Subscribe<T>(Action<T> handler);
        void Publish<T>(T message);
    }
}
