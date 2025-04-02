using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Model;
using OrderService.Service.IService;

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
        [Authorize]
        public async Task<IActionResult> PlaceOrder(PlaceOrderDto model)
        {
            var serviceResponse = await _orderService.PlaceOrderAsync(model);
            return Ok(serviceResponse);
        }

        [HttpGet("getorderbyid/{id:int}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var serviceResponse = await _orderService.GetOrderById(id);
            return Ok(serviceResponse);
        }

        [HttpGet("completeorder/orderid/{id:int}")]
        public async Task<IActionResult> CompleteOrderByOrderId(int id)
        {
            var serviceResposne = await _orderService.CompleteOrderAsync(id);
            return Ok(serviceResposne);
        }

    }
}
