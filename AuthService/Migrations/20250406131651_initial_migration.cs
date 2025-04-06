using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthService.Migrations
{
    /// <inheritdoc />
    public partial class initial_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailble = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "CreatedDate", "Email", "IsActive", "IsAvailble", "IsDeleted", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { 1, "123 Main St, New York, NY", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1001), "chetanmundlesd@gmail.com", true, null, false, "Chetan Mundle", "Pass@123", "9867598658", "Customer" },
                    { 2, "456 Elm St, Los Angeles, CA", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1014), "alice.brown@example.com", true, null, false, "Alice Brown", "Pass@123", "5698758966", "Customer" },
                    { 3, "789 Pine Ave, Chicago, IL", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1016), "michael.smith@example.com", true, null, false, "Michael Smith", "Pass@123", "1236589685", "Customer" },
                    { 4, "321 Oak St, Houston, TX", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1017), "emma.davis@example.com", true, null, false, "Emma Davis", "Pass@123", "4589675896", "Customer" },
                    { 5, "654 Maple Rd, Phoenix, AZ", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1019), "robert.wilson@example.com", true, null, false, "Robert Wilson", "Pass@123", "1254698759", "Customer" },
                    { 6, "987 Birch Blvd, Philadelphia, PA", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1090), "sophia.miller@example.com", true, null, false, "Sophia Miller", "Pass@123", "1236589685", "Customer" },
                    { 7, "246 Cedar St, San Antonio, TX", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1091), "william.johnson@example.com", true, null, false, "William Johnson", "Pass@123", "1235698759", "Customer" },
                    { 8, "135 Spruce Dr, San Diego, CA", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1093), "olivia.martinez@example.com", true, null, false, "Olivia Martinez", "Pass@123", "9658974589", "Customer" },
                    { 9, "753 Aspen Way, Dallas, TX", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1094), "james.anderson@example.com", true, null, false, "James Anderson", "Pass@123", "758965874", "Customer" },
                    { 10, "852 Redwood Ct, San Jose, CA", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1097), "isabella.thompson@example.com", true, null, false, "Isabella Thompson", "Pass@123", "3652896589", "Customer" },
                    { 11, "101 Lakeview Dr, Miami, FL", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1098), "chetanmundled@gmail.com", true, true, false, "Liam Carter", "Pass@123", "7896541201", "DeliveryPartner" },
                    { 12, "202 River Rd, Denver, CO", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1100), "emma.foster@example.com", true, true, false, "Emma Foster", "Pass@123", "7896541202", "DeliveryPartner" },
                    { 13, "303 Sunset Blvd, Seattle, WA", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1102), "noah.brooks@example.com", true, true, false, "Noah Brooks", "Pass@123", "7896541203", "DeliveryPartner" },
                    { 14, "404 Bay St, Tampa, FL", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1103), "ava.morgan@example.com", true, true, false, "Ava Morgan", "Pass@123", "7896541204", "DeliveryPartner" },
                    { 15, "505 Palm Ave, Orlando, FL", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1105), "elijah.reed@example.com", true, true, false, "Elijah Reed", "Pass@123", "7896541205", "DeliveryPartner" },
                    { 16, "606 Cedar Dr, Austin, TX", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1107), "sophia.rivera@example.com", true, true, false, "Sophia Rivera", "Pass@123", "7896541206", "DeliveryPartner" },
                    { 17, "707 Birch Ln, Portland, OR", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1108), "lucas.gray@example.com", true, true, false, "Lucas Gray", "Pass@123", "7896541207", "DeliveryPartner" },
                    { 18, "808 Spruce St, Nashville, TN", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1111), "mia.scott@example.com", true, true, false, "Mia Scott", "Pass@123", "7896541208", "DeliveryPartner" },
                    { 19, "909 Maple Ave, Boston, MA", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1112), "oliver.hill@example.com", true, true, false, "Oliver Hill", "Pass@123", "7896541209", "DeliveryPartner" },
                    { 20, "111 Willow Way, Charlotte, NC", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1114), "isabella.green@example.com", true, true, false, "Isabella Green", "Pass@123", "7896541210", "DeliveryPartner" },
                    { 21, "1212 Aspen St, Raleigh, NC", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1115), "james.adams@example.com", true, true, false, "James Adams", "Pass@123", "7896541211", "DeliveryPartner" },
                    { 22, "1313 Hickory Ln, Columbus, OH", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1117), "charlotte.perez@example.com", true, true, false, "Charlotte Perez", "Pass@123", "7896541212", "DeliveryPartner" },
                    { 23, "1414 Sycamore Rd, Atlanta, GA", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1119), "henry.turner@example.com", true, true, false, "Henry Turner", "Pass@123", "7896541213", "DeliveryPartner" },
                    { 24, "1515 Magnolia Ct, Richmond, VA", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1120), "amelia.torres@example.com", true, true, false, "Amelia Torres", "Pass@123", "7896541214", "DeliveryPartner" },
                    { 25, "1616 Cherry St, Madison, WI", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1122), "benjamin.ramirez@example.com", true, true, false, "Benjamin Ramirez", "Pass@123", "7896541215", "DeliveryPartner" },
                    { 26, "1717 Chestnut Ave, Omaha, NE", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1124), "evelyn.cox@example.com", true, true, false, "Evelyn Cox", "Pass@123", "7896541216", "DeliveryPartner" },
                    { 27, "1818 Beechwood Dr, Salt Lake City, UT", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1125), "logan.ward@example.com", true, true, false, "Logan Ward", "Pass@123", "7896541217", "DeliveryPartner" },
                    { 28, "1919 Poplar Pl, Kansas City, MO", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1127), "harper.bailey@example.com", true, true, false, "Harper Bailey", "Pass@123", "7896541218", "DeliveryPartner" },
                    { 29, "2020 Olive St, Des Moines, IA", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1128), "sebastian.bell@example.com", true, true, false, "Sebastian Bell", "Pass@123", "7896541219", "DeliveryPartner" },
                    { 30, "2121 Dogwood Blvd, Boise, ID", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1130), "ella.cooper@example.com", true, true, false, "Ella Cooper", "Pass@123", "7896541220", "DeliveryPartner" },
                    { 31, "2222 Hemlock Way, Little Rock, AR", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1131), "jackson.murphy@example.com", true, true, false, "Jackson Murphy", "Pass@123", "7896541221", "DeliveryPartner" },
                    { 32, "2323 Pine Needle Rd, Fargo, ND", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1133), "avery.howard@example.com", true, true, false, "Avery Howard", "Pass@123", "7896541222", "DeliveryPartner" },
                    { 33, "2424 Ivy Ln, Billings, MT", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1135), "daniel.ward@example.com", true, true, false, "Daniel Ward", "Pass@123", "7896541223", "DeliveryPartner" },
                    { 34, "2525 Orchid Dr, Anchorage, AK", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1137), "scarlett.flores@example.com", true, true, false, "Scarlett Flores", "Pass@123", "7896541224", "DeliveryPartner" },
                    { 35, "2626 Tulip Ln, Cheyenne, WY", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1139), "matthew.ross@example.com", true, true, false, "Matthew Ross", "Pass@123", "7896541225", "DeliveryPartner" },
                    { 36, "2727 Daisy St, Helena, MT", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1140), "luna.sanders@example.com", true, true, false, "Luna Sanders", "Pass@123", "7896541226", "DeliveryPartner" },
                    { 37, "2828 Fern Rd, Bismarck, ND", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1142), "david.jenkins@example.com", true, true, false, "David Jenkins", "Pass@123", "7896541227", "DeliveryPartner" },
                    { 38, "2929 Maplewood Ct, Dover, DE", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1143), "chloe.rogers@example.com", true, true, false, "Chloe Rogers", "Pass@123", "7896541228", "DeliveryPartner" },
                    { 39, "3030 Bluebell Rd, Jackson, MS", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1145), "joseph.bryant@example.com", true, true, false, "Joseph Bryant", "Pass@123", "7896541229", "DeliveryPartner" },
                    { 40, "3131 Tulip Hill Dr, Montgomery, AL", new DateTime(2025, 4, 6, 18, 46, 51, 31, DateTimeKind.Local).AddTicks(1146), "grace.hunter@example.com", true, true, false, "Grace Hunter", "Pass@123", "7896541230", "DeliveryPartner" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
