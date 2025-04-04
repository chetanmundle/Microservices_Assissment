using App.Common.Models;
using DeliveryService.Model;

namespace DeliveryService.Service.IService
{
    public interface IUserService
    {
        Task<AppResponse<UserDto>> BookAndGetAvailablePartenerAsync();
        Task<AppResponse> ChangeAvailabilityStatusAsync(ChangeAvailabilityReqDto req);
    }
}
