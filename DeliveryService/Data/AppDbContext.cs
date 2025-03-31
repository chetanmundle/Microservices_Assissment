using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options )
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DeliveryPerson>().HasData(new DeliveryPerson
            {
                DeliveryPersonId = 1,
                IsAvailable = true,
                Name = "John M",
                PhoneNumber = "1234567890"
            });

            modelBuilder.Entity<DeliveryPerson>().HasData(new DeliveryPerson
            {
                DeliveryPersonId = 2,
                IsAvailable = true,
                Name = "Melon ",
                PhoneNumber = "2342356743"
            });

            modelBuilder.Entity<DeliveryPerson>().HasData(new DeliveryPerson
            {
                DeliveryPersonId = 3,
                IsAvailable = true,
                Name = "Keloni S T ",
                PhoneNumber = "7684635238"
            });

            modelBuilder.Entity<DeliveryPerson>().HasData(new DeliveryPerson
            {
                DeliveryPersonId = 4,
                IsAvailable = true,
                Name = "Mr. R L",
                PhoneNumber = "0983727843"
            });

            modelBuilder.Entity<DeliveryPerson>().HasData(new DeliveryPerson
            {
                DeliveryPersonId = 5,
                IsAvailable = true,
                Name = "Steno Dev",
                PhoneNumber = "8378394384"
            });

            modelBuilder.Entity<DeliveryPerson>().HasData(new DeliveryPerson
            {
                DeliveryPersonId = 6,
                IsAvailable = true,
                Name = "John M",
                PhoneNumber = "1234567890"
            });
        }

        public DbSet<DeliveryPerson> DeliveryPersons { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
    }
}
