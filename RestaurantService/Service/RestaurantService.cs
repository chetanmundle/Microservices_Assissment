using App.Common.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using RestaurantService.Data;
using RestaurantService.Model;
using RestaurantService.Service.IService;

namespace RestaurantService.Service
{
    public class RestaurantService : IRestaurantService
    {
        private readonly AppDbContext _appDbContext;
        public RestaurantService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<AppResponse<RestaurantDto>> GetRestaurantByIdAsync(int RestaurantId)
        {
            try
            {
                var restaurant = await _appDbContext.Restaurants
                    .FirstOrDefaultAsync(r => r.RestaurantId == RestaurantId &&
                                                r.IsDeleted == false && r.IsActive == true);

                if (restaurant == null)
                {
                    return AppResponse.Fail<RestaurantDto>(null, $"Restaurant with {RestaurantId} Not Found", App.Common.Constants.HttpStatusCodes.NotFound);
                }
                var restaurantDto = restaurant.Adapt<RestaurantDto>();
                return AppResponse.Success(restaurantDto);
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<RestaurantDto>(null, ex.Message, App.Common.Constants.HttpStatusCodes.InternalServerError);
            }
        }
    }
}
