using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantService.Model;
using RestaurantService.Service.IService;

namespace RestaurantService.Controllers
{
    [Route("api/menuitems")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private readonly IMenuItemService _menuItemService;

        public MenuItemsController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpGet("getallmenuitems")]
        [Authorize]
        public async Task<IActionResult> GetAllMenuItems()
        {
            var serviceResponse = await _menuItemService.GetAllMenuItemsAsync();
            return Ok(serviceResponse);
        }

        [HttpGet("getmenubymenuid/{id}")]
        [Authorize]
        public async Task<IActionResult> GetMenuByMenuId(int id)
        {
            var serviceResponse = await _menuItemService.GetMenuItemByIdAsync(id);
            return Ok(serviceResponse);
        }

        [HttpPost("serarchMenuByRestaurant")]
        [Authorize]
        public async Task<IActionResult> SerarchMenuByRestaurant(SearchMenuByRestaurantDto model)
        {
            var serviceResponse = await _menuItemService.SerarchMenuByRestaurant(model);
            return Ok(serviceResponse);
        }
    }
}
