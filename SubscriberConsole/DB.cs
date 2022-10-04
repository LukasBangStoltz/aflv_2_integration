using microservice_1.Models;
using Newtonsoft.Json;
using Npgsql;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberConsole
{
    public class DB
    {

        
    public static async Task SendAsync(RedisValue message) {
            var connString = "Host=localhost:5432;Username=postgres;Password=P@ris2027!;Database=postgres";

            await using var conn = new NpgsqlConnection(connString);
            await conn.OpenAsync();
            var complaint = JsonConvert.DeserializeObject<Complaint>(message);
        Console.WriteLine(complaint);
            await using (var cmd = new NpgsqlCommand("INSERT INTO complaint (text, senderemail) VALUES (@t, @s)", conn))
            {
                cmd.Parameters.AddWithValue("t", complaint.Text);
                cmd.Parameters.AddWithValue("s", complaint.SenderEmail);
                await cmd.ExecuteNonQueryAsync();
}
    }
    }
}
