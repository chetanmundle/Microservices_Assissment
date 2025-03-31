using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetAllMenuItems()
        {
            var serviceResponse = await _menuItemService.GetAllMenuItemsAsync();
            return Ok(serviceResponse);
        }

        [HttpGet("getmenubymenuid/{id}")]
        public async Task<IActionResult> GetMenuByMenuId(int id)
        {
            var serviceResponse = await _menuItemService.GetMenuItemByIdAsync(id);
            return Ok(serviceResponse);
        }

    }
}
