using App.Common.Models;
using OrderService.Model;

namespace OrderService.Service.IService
{
    public interface IOrderService
    {
        Task<AppResponse<OrderDto>> PlaceOrderAsync(PlaceOrderDto req);
        Task<AppResponse<OrderDto>> GetOrderById(int id);
    }
}
