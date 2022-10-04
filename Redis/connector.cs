using StackExchange.Redis;

namespace Redis
{
    public static class Connector
    {
        private const string RedisConnectionString = "localhost:6379";
        public static ConnectionMultiplexer RConnect()
        {
              ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(RedisConnectionString);
            return connection;
    }

    }
}
