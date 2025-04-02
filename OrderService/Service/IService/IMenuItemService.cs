using App.Common.Models;
using RestaurantService.Model;

namespace OrderService.Service.IService
{
    public interface IMenuItemService
    {
        Task<AppResponse<MenuItemsDto>> GetMenuItemByIdAsync(int id);
    }
}
