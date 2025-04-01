using App.Common.Constants;
using App.Common.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Entities;
using OrderService.Model;
using OrderService.Service.IService;

namespace OrderService.Service
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IRabbitMqService _rabbitMqService;

        public OrderService(
            AppDbContext appDbContext,
            IRabbitMqService rabbitMqService
            )
        {
            _appDbContext = appDbContext;
            _rabbitMqService = rabbitMqService;
        }

        public async Task<AppResponse<OrderDto>> PlaceOrderAsync(PlaceOrderDto req)
        {
            try
            {
                var order = new Order()
                {
                    MenuItemId = req.MenuItemId,
                    RestaurantId = req.RestaurantId,
                    Status =  "Pending",
                    UserId = req.UserId,
                };
                await _appDbContext.Orders.AddAsync(order);
                await _appDbContext.SaveChangesAsync();
                var assignDeliveryDto = new AssignDeliveryDto()
                {
                    OrderId = order.OrderId,
                };
                await _rabbitMqService.SendMessageAsync(assignDeliveryDto);

                return AppResponse.Success(order.Adapt<OrderDto>());
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<OrderDto>(null, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse<OrderDto>> GetOrderById(int id)
        {
            try
            {
                var order = await _appDbContext.Orders
                    .AsNoTracking()
                    .FirstOrDefaultAsync(o => o.OrderId == id && o.IsDeleted == false && o.IsActive == true);

                if(order  == null)
                    return AppResponse.Fail<OrderDto>(null, "No Order Found", HttpStatusCodes.NotFound);

                var orderDto = order.Adapt<OrderDto>();
                return AppResponse.Success(orderDto);
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<OrderDto>(null, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }
    }
}
