using OrderService.Model;

namespace OrderService.Service.IService
{
    public interface IRabbitMqService
    {
        Task<bool> SendMessageAsync(AssignDeliveryDto message, string queueName);
    }
}
