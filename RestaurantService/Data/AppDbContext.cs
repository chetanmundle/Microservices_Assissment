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

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = 1,
                Name = "Gulab Jamun",
                Price = 100,
                RestaurantId = 1                
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = 2,
                Name = "Samosa",
                Price = 50,
                RestaurantId = 1
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = 3,
                Name = "Kachori",
                Price = 50,
                RestaurantId = 1
            });
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
    }
}
