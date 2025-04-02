using App.Common.Models;
using DeliveryService.Model;

namespace DeliveryService.Service.IService
{
    public interface IDeliveryService
    {
        Task<AppResponse<DeliveryDto>> AssignDelivery(AssignDeliveryDto req);
        Task<AppResponse> CompleteDeliveryAsync(int deliveryId);
    }
}
