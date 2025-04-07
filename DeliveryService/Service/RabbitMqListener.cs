using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using DeliveryService.Model;
using DeliveryService.Service.IService;
using DeliveryService.Utility;
public class RabbitMqListener : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;

    public RabbitMqListener(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var factory = new ConnectionFactory { HostName = "localhost" };

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var connection = await factory.CreateConnectionAsync();
                using var channel = await connection.CreateChannelAsync();

                // Queue 1: MicroserviceOrderQueue
                await ListenToQueue(channel, SD.MicroserviceOrderQueue, stoppingToken);

                // Queue 2: MicroserviceDeliveryQueue (example)
                await ListenToQueue(channel, SD.MicroserviceCancelledOrderQueue, stoppingToken);

                // Add more queues as needed...

                await Task.Delay(Timeout.Infinite, stoppingToken);
            }
            catch (Exception ex)
            {
                // Log and retry after delay
                await Task.Delay(5000, stoppingToken);
            }
        }
    }

    private async Task ListenToQueue(IChannel channel, string queueName, CancellationToken stoppingToken)
    {
        await channel.QueueDeclareAsync(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

        var consumer = new AsyncEventingBasicConsumer(channel);
        consumer.ReceivedAsync += async (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);

            using var scope = _serviceProvider.CreateScope();

            switch (queueName)
            {
                case SD.MicroserviceOrderQueue:
                    var assignDeliveryDto = JsonSerializer.Deserialize<AssignDeliveryDto>(message);
                    if (assignDeliveryDto != null)
                    {
                        var deliveryService = scope.ServiceProvider.GetRequiredService<IDeliveryService>();
                        await deliveryService.AssignDelivery(assignDeliveryDto);
                    }
                    break;

                case SD.MicroserviceCancelledOrderQueue:
                    // Example: Deserialize and call a different service
                    var deliveryUpdateDto = JsonSerializer.Deserialize<AssignDeliveryDto>(message);
                    if (deliveryUpdateDto != null)
                    {
                        var deliveryService = scope.ServiceProvider.GetRequiredService<IDeliveryService>();
                        await deliveryService.CancelDeliveryAsync(deliveryUpdateDto.OrderId);
                    }
                    break;

                    // Add more queue-specific handling here...
            }
        };

        await channel.BasicConsumeAsync(queue: queueName, autoAck: true, consumer: consumer);
    }
}

