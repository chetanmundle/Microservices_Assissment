using Microsoft.EntityFrameworkCore;
using RestaurantService.Entities;

namespace RestaurantService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options )
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = 1,
                RestaurantName = "Arav Dhaba"
            });

            var menuItems = new List<MenuItem>()
            {
                new MenuItem { MenuItemId = 1, RestaurantId = 1, Name = "Gulab Jamun", Price = 100 },
                new MenuItem { MenuItemId = 2, RestaurantId = 1, Name = "Paneer Butter Masala", Price = 250 },
                new MenuItem { MenuItemId = 3, RestaurantId = 1, Name = "Chicken Biryani", Price = 300 },
                new MenuItem { MenuItemId = 4, RestaurantId = 1, Name = "Mutton Rogan Josh", Price = 350 },
                new MenuItem { MenuItemId = 5, RestaurantId = 1, Name = "Dal Makhani", Price = 180 },
                new MenuItem { MenuItemId = 6, RestaurantId = 1, Name = "Butter Naan", Price = 50 },
                new MenuItem { MenuItemId = 7, RestaurantId = 1, Name = "Masala Dosa", Price = 120 },
                new MenuItem { MenuItemId = 8, RestaurantId = 1, Name = "Idli Sambar", Price = 90 },
                new MenuItem { MenuItemId = 9, RestaurantId = 1, Name = "Tandoori Chicken", Price = 400 },
                new MenuItem { MenuItemId = 10, RestaurantId = 1, Name = "Fish Curry", Price = 320 },
                new MenuItem { MenuItemId = 11, RestaurantId = 1, Name = "Veg Pulao", Price = 160 },
                new MenuItem { MenuItemId = 12, RestaurantId = 1, Name = "Rajma Chawal", Price = 170 },
                new MenuItem { MenuItemId = 13, RestaurantId = 1, Name = "Aloo Paratha", Price = 80 },
                new MenuItem { MenuItemId = 14, RestaurantId = 1, Name = "Malai Kofta", Price = 230 },
                new MenuItem { MenuItemId = 15, RestaurantId = 1, Name = "Shahi Paneer", Price = 260 },
                new MenuItem { MenuItemId = 16, RestaurantId = 1, Name = "Chole Bhature", Price = 150 },
                new MenuItem { MenuItemId = 17, RestaurantId = 1, Name = "Chicken Tikka Masala", Price = 310 },
                new MenuItem { MenuItemId = 18, RestaurantId = 1, Name = "Prawn Curry", Price = 370 },
                new MenuItem { MenuItemId = 19, RestaurantId = 1, Name = "Mushroom Masala", Price = 210 },
                new MenuItem { MenuItemId = 20, RestaurantId = 1, Name = "Egg Curry", Price = 200 },
                new MenuItem { MenuItemId = 21, RestaurantId = 1, Name = "Hakka Noodles", Price = 140 },
                new MenuItem { MenuItemId = 22, RestaurantId = 1, Name = "Spring Rolls", Price = 130 },
                new MenuItem { MenuItemId = 23, RestaurantId = 1, Name = "Chicken Manchurian", Price = 270 },
                new MenuItem { MenuItemId = 24, RestaurantId = 1, Name = "Veg Manchurian", Price = 190 },
                new MenuItem { MenuItemId = 25, RestaurantId = 1, Name = "Mutton Keema", Price = 330 },
                new MenuItem { MenuItemId = 26, RestaurantId = 1, Name = "Bhindi Masala", Price = 160 },
                new MenuItem { MenuItemId = 27, RestaurantId = 1, Name = "Dal Tadka", Price = 170 },
                new MenuItem { MenuItemId = 28, RestaurantId = 1, Name = "Kadhai Paneer", Price = 250 },
                new MenuItem { MenuItemId = 29, RestaurantId = 1, Name = "Jeera Rice", Price = 120 },
                new MenuItem { MenuItemId = 30, RestaurantId = 1, Name = "Chocolate Brownie", Price = 180 }
            };

            menuItems.ForEach(m =>
            {
                modelBuilder.Entity<MenuItem>().HasData(m);
            });
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
    }
}
