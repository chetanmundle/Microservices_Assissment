using System.ComponentModel.DataAnnotations;

namespace RestaurantService.Entities
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; } 
        [Required]
        public string RestaurantName { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate{ get; set; } = DateTime.Now;
    }
}
