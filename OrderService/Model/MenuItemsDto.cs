namespace RestaurantService.Model
{
    public class MenuItemsDto
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int RestaurantId { get; set; }

    }
}
