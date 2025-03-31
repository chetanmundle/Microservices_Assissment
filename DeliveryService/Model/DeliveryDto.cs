namespace DeliveryService.Model
{
    public class DeliveryDto
    {
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }
        public int DeliveryPersonId { get; set; }
        public string Status { get; set; }
    }
}
