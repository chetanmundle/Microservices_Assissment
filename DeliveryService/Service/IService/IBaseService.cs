using App.Common.Models;
using DeliveryService.Model;

namespace DeliveryService.Service.IService
{
    public interface IBaseService
    {
        Task<AppResponse<T>> SendAsync<T>(RequestDto requestDto, bool withBearer = true);
        Task<AppResponse> SendAsync(RequestDto requestDto, bool withBearer = true);
    }
}
