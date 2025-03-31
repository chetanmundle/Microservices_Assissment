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
        public DeliveryService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
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
    }
}
