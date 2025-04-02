using App.Common.Models;
using OrderService.Model;

namespace OrderService.Service.IService
{
    public interface IBaseService
    {
        Task<AppResponse<T>> SendAsync<T>(RequestDto requestDto, bool withBearer = true);
    }
}
