using App.Common.Constants;
using App.Common.Models;
using DeliveryService.Entities;
using DeliveryService.Model;
using DeliveryService.Service.IService;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Service
{
    public class DeliveryService : IDeliveryService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IOrderService _orderService;
        public DeliveryService(AppDbContext appDbContext, IOrderService orderService)
        {
            _appDbContext = appDbContext;
            _orderService = orderService;
        }
        public async Task<AppResponse<DeliveryDto>> AssignDelivery(AssignDeliveryDto req)
        {
            try
            {
                var deliveryPerson = await _appDbContext.DeliveryPersons
                    .FirstOrDefaultAsync(d => d.IsAvailable == true && d.IsDeleted == false && d.IsActive == true);
                if(deliveryPerson == null)
                {
                    return AppResponse.Fail<DeliveryDto>(null, "No Delivery Person is available at that time", HttpStatusCodes.NotFound);
                }
                var delivery = new Delivery()
                {
                    DeliveryPersonId = deliveryPerson.DeliveryPersonId,
                    OrderId = req.OrderId,
                    Status = "Pending",
                };

                await _appDbContext.AddAsync(delivery);
                deliveryPerson.IsAvailable = false;
                await _appDbContext.SaveChangesAsync();

                return AppResponse.Success(delivery.Adapt<DeliveryDto>());
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<DeliveryDto>(null, ex.Message);
            }
        }

        public async Task<AppResponse> CompleteDeliveryAsync(int deliveryId)
        {
            try
            {
                var delivery = await _appDbContext.Deliveries
                    .FirstOrDefaultAsync(d => d.DeliveryPersonId == deliveryId);

                if(delivery == null) return AppResponse.Response(false, "Data Not found",HttpStatusCodes.NotFound);

                // Here http Call to order
                var completeOrderRes = await _orderService.CompleteOrderAsync(delivery.OrderId);

                if(!completeOrderRes.IsSuccess) 
                    return AppResponse.Response(false, completeOrderRes.Message, HttpStatusCodes.InternalServerError);

                var deliveryPerson = await _appDbContext.DeliveryPersons
                    .FirstOrDefaultAsync(d => d.DeliveryPersonId == delivery.DeliveryPersonId);
                if (deliveryPerson == null) return AppResponse.Response(false, "Data Not found", HttpStatusCodes.NotFound);

                deliveryPerson.IsAvailable = true;

                delivery.Status = "Completed";

                await _appDbContext.SaveChangesAsync();
                return AppResponse.Response(true, "Delivery Completed Successfully", HttpStatusCodes.OK);
            }
            catch (Exception ex)
            {
                return AppResponse.Response(false, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }
    }
}
