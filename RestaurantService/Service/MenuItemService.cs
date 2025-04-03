using App.Common.Constants;
using App.Common.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using RestaurantService.Data;
using RestaurantService.Model;
using RestaurantService.Service.IService;

namespace RestaurantService.Service
{
    public class MenuItemService : IMenuItemService
    {
        private readonly AppDbContext _appDbContext;
        public MenuItemService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<AppResponse<IEnumerable<MenuItemsDto>>> GetAllMenuItemsAsync()
        {
            try
            {
                var menuItemList = await _appDbContext.MenuItems
                    .Where(m => m.IsActive == true && m.IsDeleted == false)
                    .ToListAsync();

                var menuItemDtoList = menuItemList.Adapt<IEnumerable<MenuItemsDto>>();

                return AppResponse.Success(menuItemDtoList);
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<IEnumerable<MenuItemsDto>>([], ex.Message, HttpStatusCodes.InternalServerError);               
            }
        }

        public async Task<AppResponse<MenuItemsDto>> GetMenuItemByIdAsync(int id)
        {
            try
            {
                var menuItem = await _appDbContext.MenuItems.AsNoTracking()
                    .FirstOrDefaultAsync(m => m.MenuItemId == id && m.IsDeleted == false && m.IsActive == true);

                if(menuItem == null)
                    return AppResponse.Fail<MenuItemsDto>(null, "Menu with this Id Not Found", HttpStatusCodes.NotFound);

                return AppResponse.Success(menuItem.Adapt<MenuItemsDto>());
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<MenuItemsDto>(null, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse<IEnumerable<MenuItemsDto>>> SerarchMenuByRestaurant(SearchMenuByRestaurantDto model)
        {
            try
            {
                    if(model == null)
                        return AppResponse.Fail<IEnumerable<MenuItemsDto>>([], "null Body", HttpStatusCodes.BadRequest);

                    var restaurant = await _appDbContext.Restaurants
                        .AsNoTracking()
                        .FirstOrDefaultAsync(r => (r.RestaurantName.ToLower() == model.RestaurantName.ToLower() || r.RestaurantId == model.RestaurantId)
                                                  && r.IsDeleted == false);

                    if(restaurant is null)
                        return AppResponse.Fail<IEnumerable<MenuItemsDto>>([], "No Restaurant Found for this", HttpStatusCodes.BadRequest);

                     var menus = await _appDbContext.MenuItems
                             .Where(m => m.RestaurantId == restaurant.RestaurantId && m.IsDeleted == false && m.IsActive == true)
                             .AsNoTracking()
                             .ToListAsync();
                     var menuDtoList = menus.Adapt<IEnumerable<MenuItemsDto>>();
                     return AppResponse.Success(menuDtoList);
   
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<IEnumerable<MenuItemsDto>>(null, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }
    }
}
