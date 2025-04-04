using AuthService.Entities;
using AuthService.Utility;
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
                new User { UserId = 1, Name = "Chetan Mundle", Address = "123 Main St, New York, NY", Email = "chetanmundlesd@gmail.com", Password = "Pass@123", Role = SD.CustomerRole, PhoneNumber = "9867598658" },
                new User { UserId = 2, Name = "Alice Brown", Address = "456 Elm St, Los Angeles, CA", Email = "alice.brown@example.com", Password = "Pass@123" , Role = SD.CustomerRole, PhoneNumber = "5698758966" },
                new User { UserId = 3, Name = "Michael Smith", Address = "789 Pine Ave, Chicago, IL", Email = "michael.smith@example.com", Password = "Pass@123", Role = SD.CustomerRole, PhoneNumber = "1236589685" },
                new User {UserId = 4, Name = "Emma Davis", Address = "321 Oak St, Houston, TX", Email = "emma.davis@example.com", Password = "Pass@123", Role = SD.CustomerRole, PhoneNumber = "4589675896"},
                new User { UserId = 5, Name = "Robert Wilson", Address = "654 Maple Rd, Phoenix, AZ", Email = "robert.wilson@example.com", Password = "Pass@123", Role = SD.CustomerRole, PhoneNumber = "1254698759" },
                new User { UserId = 6, Name = "Sophia Miller", Address = "987 Birch Blvd, Philadelphia, PA", Email = "sophia.miller@example.com", Password = "Pass@123" , Role = SD.CustomerRole, PhoneNumber = "1236589685"},
                new User { UserId = 7, Name = "William Johnson", Address = "246 Cedar St, San Antonio, TX", Email = "william.johnson@example.com", Password = "Pass@123", Role = SD.CustomerRole, PhoneNumber = "1235698759" },
                new User { UserId = 8, Name = "Olivia Martinez", Address = "135 Spruce Dr, San Diego, CA", Email = "olivia.martinez@example.com", Password = "Pass@123" , Role = SD.CustomerRole, PhoneNumber = "9658974589"},
                new User { UserId = 9, Name = "James Anderson", Address = "753 Aspen Way, Dallas, TX", Email = "james.anderson@example.com", Password = "Pass@123" , Role = SD.CustomerRole, PhoneNumber = "758965874"},
                new User { UserId = 10, Name = "Isabella Thompson", Address = "852 Redwood Ct, San Jose, CA", Email = "isabella.thompson@example.com", Password = "Pass@123" , Role = SD.CustomerRole, PhoneNumber = "3652896589" },

                // Delivery Partners
                new User { UserId = 11, Name = "Liam Carter", Address = "101 Lakeview Dr, Miami, FL", Email = "chetanmundled@gmail.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541201", IsAvailble = true },
                new User { UserId = 12, Name = "Emma Foster", Address = "202 River Rd, Denver, CO", Email = "emma.foster@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541202", IsAvailble = true },
                new User { UserId = 13, Name = "Noah Brooks", Address = "303 Sunset Blvd, Seattle, WA", Email = "noah.brooks@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541203", IsAvailble = true },
                new User { UserId = 14, Name = "Ava Morgan", Address = "404 Bay St, Tampa, FL", Email = "ava.morgan@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541204", IsAvailble = true },
                new User { UserId = 15, Name = "Elijah Reed", Address = "505 Palm Ave, Orlando, FL", Email = "elijah.reed@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541205", IsAvailble = true },
                new User { UserId = 16, Name = "Sophia Rivera", Address = "606 Cedar Dr, Austin, TX", Email = "sophia.rivera@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541206", IsAvailble = true },
                new User { UserId = 17, Name = "Lucas Gray", Address = "707 Birch Ln, Portland, OR", Email = "lucas.gray@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541207", IsAvailble = true },
                new User { UserId = 18, Name = "Mia Scott", Address = "808 Spruce St, Nashville, TN", Email = "mia.scott@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541208", IsAvailble = true },
                new User { UserId = 19, Name = "Oliver Hill", Address = "909 Maple Ave, Boston, MA", Email = "oliver.hill@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541209", IsAvailble = true },
                new User { UserId = 20, Name = "Isabella Green", Address = "111 Willow Way, Charlotte, NC", Email = "isabella.green@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541210", IsAvailble = true },
                new User { UserId = 21, Name = "James Adams", Address = "1212 Aspen St, Raleigh, NC", Email = "james.adams@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541211", IsAvailble = true },
                new User { UserId = 22, Name = "Charlotte Perez", Address = "1313 Hickory Ln, Columbus, OH", Email = "charlotte.perez@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541212", IsAvailble = true },
                new User { UserId = 23, Name = "Henry Turner", Address = "1414 Sycamore Rd, Atlanta, GA", Email = "henry.turner@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541213", IsAvailble = true },
                new User { UserId = 24, Name = "Amelia Torres", Address = "1515 Magnolia Ct, Richmond, VA", Email = "amelia.torres@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541214", IsAvailble = true },
                new User { UserId = 25, Name = "Benjamin Ramirez", Address = "1616 Cherry St, Madison, WI", Email = "benjamin.ramirez@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541215", IsAvailble = true },
                new User { UserId = 26, Name = "Evelyn Cox", Address = "1717 Chestnut Ave, Omaha, NE", Email = "evelyn.cox@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541216", IsAvailble = true },
                new User { UserId = 27, Name = "Logan Ward", Address = "1818 Beechwood Dr, Salt Lake City, UT", Email = "logan.ward@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541217", IsAvailble = true },
                new User { UserId = 28, Name = "Harper Bailey", Address = "1919 Poplar Pl, Kansas City, MO", Email = "harper.bailey@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541218", IsAvailble = true },
                new User { UserId = 29, Name = "Sebastian Bell", Address = "2020 Olive St, Des Moines, IA", Email = "sebastian.bell@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541219", IsAvailble = true },
                new User { UserId = 30, Name = "Ella Cooper", Address = "2121 Dogwood Blvd, Boise, ID", Email = "ella.cooper@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541220", IsAvailble = true },
                new User { UserId = 31, Name = "Jackson Murphy", Address = "2222 Hemlock Way, Little Rock, AR", Email = "jackson.murphy@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541221", IsAvailble = true },
                new User { UserId = 32, Name = "Avery Howard", Address = "2323 Pine Needle Rd, Fargo, ND", Email = "avery.howard@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541222", IsAvailble = true },
                new User { UserId = 33, Name = "Daniel Ward", Address = "2424 Ivy Ln, Billings, MT", Email = "daniel.ward@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541223", IsAvailble = true },
                new User { UserId = 34, Name = "Scarlett Flores", Address = "2525 Orchid Dr, Anchorage, AK", Email = "scarlett.flores@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541224", IsAvailble = true },
                new User { UserId = 35, Name = "Matthew Ross", Address = "2626 Tulip Ln, Cheyenne, WY", Email = "matthew.ross@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541225", IsAvailble = true },
                new User { UserId = 36, Name = "Luna Sanders", Address = "2727 Daisy St, Helena, MT", Email = "luna.sanders@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541226", IsAvailble = true },
                new User { UserId = 37, Name = "David Jenkins", Address = "2828 Fern Rd, Bismarck, ND", Email = "david.jenkins@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541227", IsAvailble = true },
                new User { UserId = 38, Name = "Chloe Rogers", Address = "2929 Maplewood Ct, Dover, DE", Email = "chloe.rogers@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541228", IsAvailble = true },
                new User { UserId = 39, Name = "Joseph Bryant", Address = "3030 Bluebell Rd, Jackson, MS", Email = "joseph.bryant@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541229", IsAvailble = true },
                new User { UserId = 40, Name = "Grace Hunter", Address = "3131 Tulip Hill Dr, Montgomery, AL", Email = "grace.hunter@example.com", Password = "Pass@123", Role = SD.DeliveryPartnerRole, PhoneNumber = "7896541230", IsAvailble = true }
            };

            users.ForEach(u =>
            {
                modelBuilder.Entity<User>().HasData(u);
            });          
           
        }

        public DbSet<User> Users { get; set; }

    }
}
