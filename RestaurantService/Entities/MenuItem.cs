using System.ComponentModel.DataAnnotations;

namespace RestaurantService.Entities
{
    public class MenuItem
    {
        [Key]
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int RestaurantId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Restaurant Restaurant { get; set; }

    }
}
