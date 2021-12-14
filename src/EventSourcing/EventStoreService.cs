using EventStore.ClientAPI;
using Microsoft.Extensions.Configuration;
using System;

namespace EventSourcing
{
    public class EventStoreService : IEventStoreService
    {
        private readonly IEventStoreConnection _connection;

        public EventStoreService(IConfiguration configuration)
        {
            var consetting = ConnectionSettings.Create().DisableTls().Build();
            _connection = EventStoreConnection.Create(consetting, new Uri("tcp://admin:changeit@localhost:1113"));

            _connection.ConnectAsync().Wait();
        }

        public IEventStoreConnection GetConnection()
        {
            return _connection;
        }
    }
}
