using AuthService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options )
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<User> users = new List<User>()
            {
                new User { UserId = 1, Name = "Chetan Mundle", Address = "123 Main St, New York, NY", Email = "chetanmundlesd@gmail.com", Password = "Pass@123" },
                new User { UserId = 2, Name = "Alice Brown", Address = "456 Elm St, Los Angeles, CA", Email = "alice.brown@example.com", Password = "Pass@123" },
                new User { UserId = 3, Name = "Michael Smith", Address = "789 Pine Ave, Chicago, IL", Email = "michael.smith@example.com", Password = "Pass@123" },
                new User { UserId = 4, Name = "Emma Davis", Address = "321 Oak St, Houston, TX", Email = "emma.davis@example.com", Password = "Pass@123" },
                new User { UserId = 5, Name = "Robert Wilson", Address = "654 Maple Rd, Phoenix, AZ", Email = "robert.wilson@example.com", Password = "Pass@123" },
                new User { UserId = 6, Name = "Sophia Miller", Address = "987 Birch Blvd, Philadelphia, PA", Email = "sophia.miller@example.com", Password = "Pass@123" },
                new User { UserId = 7, Name = "William Johnson", Address = "246 Cedar St, San Antonio, TX", Email = "william.johnson@example.com", Password = "Pass@123" },
                new User { UserId = 8, Name = "Olivia Martinez", Address = "135 Spruce Dr, San Diego, CA", Email = "olivia.martinez@example.com", Password = "Pass@123" },
                new User { UserId = 9, Name = "James Anderson", Address = "753 Aspen Way, Dallas, TX", Email = "james.anderson@example.com", Password = "Pass@123" },
                new User { UserId = 10, Name = "Isabella Thompson", Address = "852 Redwood Ct, San Jose, CA", Email = "isabella.thompson@example.com", Password = "Pass@123" }
            };

            users.ForEach(u =>
            {
                modelBuilder.Entity<User>().HasData(u);
            });          
           
        }

        public DbSet<User> Users { get; set; }

    }
}
