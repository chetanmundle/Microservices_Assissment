using OrderService.Model;
using OrderService.Service.IService;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace OrderService.Service
{
    public class RabbitMqService : IRabbitMqService
    {
        public async Task<bool> SendMessageAsync(AssignDeliveryDto message)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(queue: "MicroserviceOrderQueue", durable: false, exclusive: false, autoDelete: false,
                arguments: null);

            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));

            await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "MicroserviceOrderQueue", body: body);

            return true;
        }
    }
}
