using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Model;
using OrderService.Service.IService;
using OrderService.Utility;

namespace OrderService.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("placeorder")]
        [Authorize(Roles = SD.CustomerRole)]
        public async Task<IActionResult> PlaceOrder(PlaceOrderDto model)
        {
            var serviceResponse = await _orderService.PlaceOrderAsync(model);
            return Ok(serviceResponse);
        }

        [HttpGet("getorderbyid/{id:int}")]
        [Authorize(Roles = $"{SD.CustomerRole}, {SD.DeliveryPartnerRole}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var serviceResponse = await _orderService.GetOrderById(id);
            return Ok(serviceResponse);
        }

        [HttpGet("completeorder/orderid/{id:int}")]
        [Authorize(Roles = SD.DeliveryPartnerRole)]
        public async Task<IActionResult> CompleteOrderByOrderId(int id)
        {
            var serviceResponse = await _orderService.CompleteOrderAsync(id);
            return Ok(serviceResponse);
        }

        [HttpGet("getAllOrders")]
        public async Task<IActionResult> GetAllOrders()
        {
            var serviceResponse = await _orderService.GetAllOrdersAsync();
            return Ok(serviceResponse);
        }

        [HttpGet("getOrdersByUserId/{id:int}")]
        [Authorize(Roles = SD.CustomerRole)]
        public async Task<IActionResult> GetOrdersByUserId(int id)
        {
            var serviceResponse = await _orderService.GetOrdersByUserIdAsync(id);
            return Ok(serviceResponse);
        }

        [HttpPost("cancelOrder")]
        [Authorize(Roles = $"{SD.CustomerRole}, {SD.DeliveryPartnerRole}")]
        public async Task<IActionResult> CancelOrder(CancelOrderReqDto model)
        {
            var serviceResponse = await _orderService.CancelOrderAsync(model);
            return Ok(serviceResponse);
        }

    }
}
