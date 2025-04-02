using App.Common.Models;

namespace DeliveryService.Service.IService
{
    public interface IOrderService
    {
        Task<AppResponse> CompleteOrderAsync(int id); // id is orderId
    }
}
