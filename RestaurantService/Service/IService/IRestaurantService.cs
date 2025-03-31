using App.Common.Models;
using RestaurantService.Model;

namespace RestaurantService.Service.IService
{
    public interface IRestaurantService
    {
        Task<AppResponse<RestaurantDto>> GetRestaurantByIdAsync(int RestaurantId);
    }
}
