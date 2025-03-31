namespace OrderService.Model
{
    public class PlaceOrderDto
    {
        public int RestaurantId { get; set; }
        public int MenuItemId { get; set; }
        public int UserId { get; set; }
    }
}
