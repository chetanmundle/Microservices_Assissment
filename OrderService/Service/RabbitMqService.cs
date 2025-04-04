using OrderService.Model;
using OrderService.Service.IService;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace OrderService.Service
{
    public class RabbitMqService : IRabbitMqService
    {
        public async Task<bool> SendMessageAsync(AssignDeliveryDto message, string queueName)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(queue: queueName, durable: false, exclusive: false, autoDelete: false,
                arguments: null);

            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));

            await channel.BasicPublishAsync(exchange: string.Empty, routingKey: queueName, body: body);

            return true;
        }
    }
}
