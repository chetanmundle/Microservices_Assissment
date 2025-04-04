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

            //var deliveryPersons = new List<DeliveryPerson>()
            //{
            //    new DeliveryPerson { DeliveryPersonId = 1, Name = "John", PhoneNumber = "5698745892", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 2, Name = "Alice", PhoneNumber = "6589741235", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 3, Name = "Michael", PhoneNumber = "7458963214", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 4, Name = "Emma", PhoneNumber = "8523697415", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 5, Name = "Robert", PhoneNumber = "9632587416", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 6, Name = "Sophia", PhoneNumber = "7418529635", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 7, Name = "William", PhoneNumber = "1597534862", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 8, Name = "Olivia", PhoneNumber = "3571598246", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 9, Name = "James", PhoneNumber = "2589631475", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 10, Name = "Isabella", PhoneNumber = "3698521475", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 11, Name = "Benjamin", PhoneNumber = "4561237895", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 12, Name = "Mia", PhoneNumber = "7896541236", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 13, Name = "Daniel", PhoneNumber = "8527419635", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 14, Name = "Charlotte", PhoneNumber = "7419638521", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 15, Name = "Elijah", PhoneNumber = "7531596248", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 16, Name = "Amelia", PhoneNumber = "8523579516", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 17, Name = "Henry", PhoneNumber = "9517538524", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 18, Name = "Harper", PhoneNumber = "7894561239", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 19, Name = "Lucas", PhoneNumber = "9514263875", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 20, Name = "Evelyn", PhoneNumber = "3652147895", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 21, Name = "Mason", PhoneNumber = "1247896352", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 22, Name = "Avery", PhoneNumber = "6985741325", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 23, Name = "Logan", PhoneNumber = "3574126985", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 24, Name = "Scarlett", PhoneNumber = "7895236147", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 25, Name = "Ethan", PhoneNumber = "4126985732", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 26, Name = "Abigail", PhoneNumber = "7896523145", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 27, Name = "Alexander", PhoneNumber = "1236985742", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 28, Name = "Grace", PhoneNumber = "6987415236", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 29, Name = "Jack", PhoneNumber = "2143658796", IsAvailable = true },
            //    new DeliveryPerson { DeliveryPersonId = 30, Name = "Ella", PhoneNumber = "9874563215", IsAvailable = true }
            //};

            //deliveryPersons.ForEach(d =>
            //{
            //    modelBuilder.Entity<DeliveryPerson>().HasData(d);
            //});
        }

        //public DbSet<DeliveryPerson> DeliveryPersons { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
    }
}
