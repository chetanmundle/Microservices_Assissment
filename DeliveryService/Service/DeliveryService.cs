using App.Common.Constants;
using App.Common.Models;
using DeliveryService.Entities;
using DeliveryService.Model;
using DeliveryService.Service.IService;
using DeliveryService.Utility;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Service
{
    public class DeliveryService : IDeliveryService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        public DeliveryService(
            AppDbContext appDbContext,
            IOrderService orderService,
            IUserService userService)
        {
            _appDbContext = appDbContext;
            _orderService = orderService;
            _userService = userService;
        }
        public async Task<AppResponse<DeliveryDto>> AssignDelivery(AssignDeliveryDto req)
        {
            int deliveryId = 0;
            try
            {
                //var deliveryPerson = await _appDbContext.DeliveryPersons
                //    .FirstOrDefaultAsync(d => d.IsAvailable == true && d.IsDeleted == false && d.IsActive == true);
                var deliveryPerson = await _userService.BookAndGetAvailablePartenerAsync();
                if (!deliveryPerson.IsSuccess)
                    return AppResponse.Fail<DeliveryDto>(null, deliveryPerson.Message, HttpStatusCodes.NotFound);

                deliveryId = deliveryPerson.Data.UserId;
                var delivery = new Delivery()
                {
                    DeliveryPersonId = deliveryPerson.Data.UserId,
                    OrderId = req.OrderId,
                    Status = SD.Status_Pending,
                };

                await _appDbContext.AddAsync(delivery);
                await _appDbContext.SaveChangesAsync();

                return AppResponse.Success(delivery.Adapt<DeliveryDto>());
            }
            catch (Exception ex)
            {
                // make the delivery person Free becouse of fails to create delivery
                if(deliveryId != 0)
                {
                    var changeDto = new ChangeAvailabilityReqDto()
                    {
                        UserId = deliveryId,
                        IsAvailable = true,
                    };
                    await _userService.ChangeAvailabilityStatusAsync(changeDto);
                }
                return AppResponse.Fail<DeliveryDto>(null, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse> CompleteDeliveryAsync(int deliveryId)
        {
            try
            {
                var delivery = await _appDbContext.Deliveries
                    .FirstOrDefaultAsync(d => d.DeliveryId == deliveryId);

                if(delivery == null) 
                    return AppResponse.Response(false, "Data Not found",HttpStatusCodes.NotFound);


                if (!string.Equals(delivery.Status, SD.Status_Pending))
                    return AppResponse.Response(false, $"Delivery is {delivery.Status}. Unble to Complete", HttpStatusCodes.NotFound);

                // Here http Call to order
                var completeOrderRes = await _orderService.CompleteOrderAsync(delivery.OrderId);

                if(!completeOrderRes.IsSuccess) 
                    return AppResponse.Response(false, completeOrderRes.Message, HttpStatusCodes.InternalServerError);

                //var deliveryPerson = await _appDbContext.DeliveryPersons
                //    .FirstOrDefaultAsync(d => d.DeliveryPersonId == delivery.DeliveryPersonId);
                var changeDto = new ChangeAvailabilityReqDto()
                {
                    UserId = delivery.DeliveryPersonId,
                    IsAvailable = true,
                };
                var changeAvailabilityStatus = await _userService.ChangeAvailabilityStatusAsync(changeDto);
                if (!changeAvailabilityStatus.IsSuccess) 
                    return AppResponse.Response(false, changeAvailabilityStatus.Message, HttpStatusCodes.NotFound);

                //deliveryPerson.IsAvailable = true;

                delivery.Status = SD.Status_Completed;

                await _appDbContext.SaveChangesAsync();
                return AppResponse.Response(true, "Delivery Completed Successfully", HttpStatusCodes.OK);
            }
            catch (Exception ex)
            {
                return AppResponse.Response(false, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse> CancelDeliveryAsync(int orderId)
        {
            try
            {
                var delivery = await _appDbContext.Deliveries
                    .FirstOrDefaultAsync(d => d.OrderId == orderId);

                if (delivery is null || !string.Equals(delivery.Status, SD.Status_Pending)) 
                    return AppResponse.Response(false, "Data Not Found", HttpStatusCodes.NotFound);

                // http call to free delivery partner
                var changeDto = new ChangeAvailabilityReqDto()
                {
                    UserId = delivery.DeliveryPersonId,
                    IsAvailable = true,
                };
                
                var changeAvailabilityStatus = await _userService.ChangeAvailabilityStatusAsync(changeDto);
                if (!changeAvailabilityStatus.IsSuccess)
                    return AppResponse.Response(false, changeAvailabilityStatus.Message, HttpStatusCodes.NotFound);

                delivery.Status = SD.Status_Cancelled;

                await _appDbContext.SaveChangesAsync();

                return AppResponse.Response(true, "Delivery Canelled Successfully", HttpStatusCodes.OK);
            }
            catch (Exception ex)
            {
                return AppResponse.Response(false, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }
    }
}
