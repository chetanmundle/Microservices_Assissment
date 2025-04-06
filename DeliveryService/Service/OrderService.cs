using App.Common.Constants;
using App.Common.Models;
using DeliveryService.Model;
using DeliveryService.Service.IService;
using DeliveryService.Utility;

namespace DeliveryService.Service
{
    public class OrderService : IOrderService
    {
        private readonly IBaseService _baseService;
        public OrderService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<AppResponse> CompleteOrderAsync(int id)
        {
			try
			{
                return await _baseService.SendAsync(new RequestDto()
                {
                    ApiType = SD.ApiType.GET,
                    Url = SD.ApiGatwayAPIBase + "/orders/completeorder/orderid/" + id
                }, true);
            }
			catch (Exception ex)
			{
                return AppResponse.Response(false, ex.Message, HttpStatusCodes.InternalServerError);
			}
        }
    }
}
