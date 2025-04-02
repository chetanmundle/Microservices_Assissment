using App.Common.Models;
using OrderService.Model;
using OrderService.Service.IService;
using OrderService.Utility;
using RestaurantService.Model;

namespace OrderService.Service
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IBaseService _baseService;
        public MenuItemService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<AppResponse<MenuItemsDto>> GetMenuItemByIdAsync(int id)
        {
            //return await _baseService.SendAsync(new RequestDto()
            //{
            //    ApiType = SD.ApiType.GET,
            //    Data = null,
            //    Url = SD.ApiGatwayAPIBase + "/api/order/CreateOrder"
            //});

            return await _baseService.SendAsync<MenuItemsDto>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ApiGatwayAPIBase + "/menuitems/getmenubymenuid/" + id
            });
        }
    }
}
