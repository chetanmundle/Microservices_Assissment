using App.Common.Constants;
using App.Common.Models;
using DeliveryService.Model;
using DeliveryService.Service.IService;
using DeliveryService.Utility;

namespace DeliveryService.Service
{
    public class UserService : IUserService
    {
        private readonly IBaseService _baseService;
        public UserService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<AppResponse<UserDto>> BookAndGetAvailablePartenerAsync()
        {
            try
            {
                return await _baseService.SendAsync<UserDto>(new RequestDto()
                {
                    ApiType = SD.ApiType.GET,
                    Url = SD.ApiGatwayAPIBase + "/users/bookAndGetAvailblePartner"
                }, false);

            }
            catch (Exception ex)
            {
                return AppResponse.Fail<UserDto>(null, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse> ChangeAvailabilityStatusAsync(ChangeAvailabilityReqDto req)
        {
            try
            {
                return await _baseService.SendAsync(new RequestDto()
                {
                    ApiType = SD.ApiType.POST,
                    Url = SD.ApiGatwayAPIBase + "/users/changeAvailabilityStatus",
                    Data = req
                }, true);

            }
            catch (Exception ex)
            {
                return AppResponse.Response(false, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }
    }
}
