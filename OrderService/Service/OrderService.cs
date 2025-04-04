using App.Common.Constants;
using App.Common.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Entities;
using OrderService.Model;
using OrderService.Service.IService;
using OrderService.Utility;

namespace OrderService.Service
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IRabbitMqService _rabbitMqService;
        private readonly IMenuItemService _menuItemService;

        public OrderService(
            AppDbContext appDbContext,
            IRabbitMqService rabbitMqService,
            IMenuItemService menuItemService
            )
        {
            _appDbContext = appDbContext;
            _rabbitMqService = rabbitMqService;
            _menuItemService = menuItemService;
        }

        public async Task<AppResponse<OrderDto>> PlaceOrderAsync(PlaceOrderDto req)
        {
            try
            {
                var menuItemRes = await _menuItemService.GetMenuItemByIdAsync(req.MenuItemId);
                if(!menuItemRes.IsSuccess) 
                    return AppResponse.Fail<OrderDto>(null, menuItemRes.Message, HttpStatusCodes.InternalServerError);

                var order = new Order()
                {
                    MenuItemId = req.MenuItemId,
                    RestaurantId = menuItemRes.Data.RestaurantId,
                    Status =  SD.Status_Pending,
                    UserId = req.UserId,
                };

                await _appDbContext.Orders.AddAsync(order);
                await _appDbContext.SaveChangesAsync();
                var assignDeliveryDto = new AssignDeliveryDto()
                {
                    OrderId = order.OrderId,
                };

                // Add into queue
                await _rabbitMqService.SendMessageAsync(assignDeliveryDto, SD.MicroserviceOrderQueue);

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

        public async Task<AppResponse> CompleteOrderAsync(int id)
        {
            try
            {
                var order = await _appDbContext.Orders.FirstOrDefaultAsync(o => o.OrderId == id);
                if (order is null) return AppResponse.Response(false, "Order with this Id not Found", HttpStatusCodes.NotFound);
                order.Status = SD.Status_Completed;
                
                await _appDbContext.SaveChangesAsync();
                return AppResponse.Response(true, "Order Completed Successfully", HttpStatusCodes.OK);

            }
            catch (Exception ex)
            {
                return AppResponse.Response(false, ex.Message, HttpStatusCodes.OK);
            }
        }

        public async Task<AppResponse<IEnumerable<OrderDto>>> GetAllOrdersAsync()
        {
            try
            {
                var orders = await _appDbContext.Orders
                    .Where(o => o.IsDeleted == false && o.IsActive == true)
                    .AsNoTracking()
                    .ToListAsync();
                var ordesDtoList = orders.Adapt<IEnumerable<OrderDto>>();
                return AppResponse.Success(ordesDtoList);
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<IEnumerable<OrderDto>>([], ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse<IEnumerable<OrderDto>>> GetOrdersByUserIdAsync(int id)
        {
            try
            {
                var orders = await _appDbContext.Orders
                    .Where(o => o.UserId == id && o.IsDeleted == false && o.IsActive == true )
                    .AsNoTracking()
                    .ToListAsync();
                var ordesDtoList = orders.Adapt<IEnumerable<OrderDto>>();
                return AppResponse.Success(ordesDtoList);
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<IEnumerable<OrderDto>>([], ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse> CancelOrderAsync(CancelOrderReqDto req)
        {
            try
            {
                var order = await _appDbContext.Orders.FirstOrDefaultAsync(o => o.OrderId == req.OrderId && o.IsDeleted == false);
                if (order == null)
                    return AppResponse.Response(false, "No Order Found for this Id", HttpStatusCodes.NotFound);

                if(!string.Equals(SD.Status_Pending, order.Status))
                {
                    return AppResponse.Response(false, $"Your order is {order.Status}. Unble to Cancel It." , HttpStatusCodes.NotFound);
                }

                order.Status = SD.Status_Cancelled;
                // Add into queue
                var cancelDeliveryDto = new AssignDeliveryDto()
                {
                    OrderId = order.OrderId,
                };
                // Send to queue
                await _rabbitMqService.SendMessageAsync(cancelDeliveryDto, SD.MicroserviceCancelledOrderQueue);
                await _appDbContext.SaveChangesAsync();
                return AppResponse.Response(true, "Your Order is Cancelled Successfully..");
            }
            catch (Exception ex)
            {
                return AppResponse.Response(false, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }
    }
}
