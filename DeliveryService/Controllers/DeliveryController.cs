using DeliveryService.Model;
using DeliveryService.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryService.Controllers
{
    [Route("api/delivery")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryService _deliveryService;

        public DeliveryController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        [HttpPost("assigndelivery")]
        public async Task<IActionResult> AssignDelivery(AssignDeliveryDto model)
        {
            var serviceResponse = await _deliveryService.AssignDelivery(model);
            return Ok(serviceResponse);
        }
    }
}
