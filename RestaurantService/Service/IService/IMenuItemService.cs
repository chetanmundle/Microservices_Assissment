using App.Common.Models;
using RestaurantService.Model;

namespace RestaurantService.Service.IService
{
    public interface IMenuItemService
    {
        Task<AppResponse<MenuItemsDto>> GetMenuItemByIdAsync(int id);
        Task<AppResponse<IEnumerable<MenuItemsDto>>> GetAllMenuItemsAsync();
        Task<AppResponse<IEnumerable<MenuItemsDto>>> SerarchMenuByRestaurant(SearchMenuByRestaurantDto model);
    }
}
