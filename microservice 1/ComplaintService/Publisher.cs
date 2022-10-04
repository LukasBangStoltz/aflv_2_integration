using microservice_1.Models;
using Newtonsoft.Json;
using Redis;
using StackExchange.Redis;

namespace microservice_1.ComplaintService
{
    public interface IPublisher
    {
        public bool Publish(Complaint complaint);
    }

    public class Publisher : IPublisher
    {
        ConnectionMultiplexer connection =  Connector.RConnect();
        
        private const string Channel = "test-channel";
        public bool Publish(Complaint complaint)
        {
            try
            {
                var pubsub = connection.GetSubscriber();
                var serializedComplaint = JsonConvert.SerializeObject(complaint);

                pubsub.PublishAsync(Channel, serializedComplaint, CommandFlags.FireAndForget);
                Console.Write("Message Successfully sent to test-channel");

                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
