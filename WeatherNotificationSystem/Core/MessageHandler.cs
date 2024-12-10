using System;
using System.Collections.Generic;

namespace WeatherNotificationSystem.Core
{
    public class MessageHandler : IMessageHandler
    {
        private readonly Dictionary<Type, List<Action<object>>> _routes = new();

        public void Subscribe<T>(Action<T> handler)
        {
            var messageType = typeof(T);
            if (!_routes.ContainsKey(messageType))
                _routes[messageType] = new List<Action<object>>();

            _routes[messageType].Add(message => handler((T)message));
        }

        public void Publish<T>(T message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message), "Message cannot be null.");

            var messageType = typeof(T);
            if (_routes.ContainsKey(messageType))
            {
                foreach (var handler in _routes[messageType])
                {
                    handler(message!);
                }
            }
        }

    }
}
