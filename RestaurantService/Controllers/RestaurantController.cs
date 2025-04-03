using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantService.Service.IService;

namespace RestaurantService.Controllers
{
    [Route("api/restaurants")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet("getrestaurantbyid/{id}")]
        public async Task<IActionResult> GetRestaurantById(int id)
        {
            var serviceResponse = await _restaurantService.GetRestaurantByIdAsync(id);
            return Ok(serviceResponse);
        }

    }
}
