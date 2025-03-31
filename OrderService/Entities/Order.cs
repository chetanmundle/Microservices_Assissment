using System.ComponentModel.DataAnnotations;

namespace OrderService.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int RestaurantId { get; set; }
        public int MenuItemId { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
