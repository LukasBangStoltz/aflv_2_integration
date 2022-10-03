using StackExchange.Redis;

namespace microservice_1.ComplaintService
{
    public class Publisher
    {
        private const string RedisConnectionString = "localhost:6379";
        private static ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(RedisConnectionString);
        private const string Channel = "test-channel";

        public void Publish()
        {
            var pubsub = connection.GetSubscriber();

            pubsub.PublishAsync(Channel, "This is a test message!!", CommandFlags.FireAndForget);
            Console.Write("Message Successfully sent to test-channel");
            Console.ReadLine();
        }
    }
}
