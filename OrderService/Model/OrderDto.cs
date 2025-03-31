namespace OrderService.Model
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int RestaurantId { get; set; }
        public int MenuItemId { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
    }
}
