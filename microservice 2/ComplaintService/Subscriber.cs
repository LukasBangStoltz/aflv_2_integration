using StackExchange.Redis;

namespace microservice_2.ComplaintService
{
    public class Subscriber
    {
        private const string RedisConnectionString = "localhost:6379";
        private static ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(RedisConnectionString);
        private const string Channel = "test-channel";
        

        public void Subscribe() { 
            Console.WriteLine("Listening test-channel");
            var pubsub = connection.GetSubscriber();

            pubsub.Subscribe(Channel, (channel, message) => Console.Write("Message received from test-channel : " + message));
            Console.ReadLine();
        }
    }
}
