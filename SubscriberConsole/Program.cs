using microservice_1.Models;
using Newtonsoft.Json;
using Npgsql;
using StackExchange.Redis;
using SubscriberConsole;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

class Program
{
    
    
    private const string Channel = "test-channel";
    static async Task Main(string[] args)
    {
        ConnectionMultiplexer connection = Redis.Connector.RConnect();
        Console.WriteLine("Listening test-channel");
        var pubsub = connection.GetSubscriber();
        pubsub.Subscribe(Channel, async (channel, message) => {
        DB.SendAsync(message);
        }
        );
        Console.ReadLine();
    }
}