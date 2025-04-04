using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthService.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvailble",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3568), null, "9867598658", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3584), null, "5698758966", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3586), null, "1236589685", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3587), null, "4589675896", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3588), null, "1254698759", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3592), null, "1236589685", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3593), null, "1235698759", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3595), null, "9658974589", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3596), null, "758965874", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IsAvailble", "PhoneNumber", "Role" },
                values: new object[] { new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3598), null, "3652896589", "Customer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "CreatedDate", "Email", "IsActive", "IsAvailble", "IsDeleted", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { 11, "101 Lakeview Dr, Miami, FL", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3599), "chetanmundled@gmail.com", true, true, false, "Liam Carter", "Pass@123", "7896541201", "DeliveryPartner" },
                    { 12, "202 River Rd, Denver, CO", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3602), "emma.foster@example.com", true, true, false, "Emma Foster", "Pass@123", "7896541202", "DeliveryPartner" },
                    { 13, "303 Sunset Blvd, Seattle, WA", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3603), "noah.brooks@example.com", true, true, false, "Noah Brooks", "Pass@123", "7896541203", "DeliveryPartner" },
                    { 14, "404 Bay St, Tampa, FL", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3605), "ava.morgan@example.com", true, true, false, "Ava Morgan", "Pass@123", "7896541204", "DeliveryPartner" },
                    { 15, "505 Palm Ave, Orlando, FL", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3606), "elijah.reed@example.com", true, true, false, "Elijah Reed", "Pass@123", "7896541205", "DeliveryPartner" },
                    { 16, "606 Cedar Dr, Austin, TX", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3608), "sophia.rivera@example.com", true, true, false, "Sophia Rivera", "Pass@123", "7896541206", "DeliveryPartner" },
                    { 17, "707 Birch Ln, Portland, OR", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3609), "lucas.gray@example.com", true, true, false, "Lucas Gray", "Pass@123", "7896541207", "DeliveryPartner" },
                    { 18, "808 Spruce St, Nashville, TN", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3611), "mia.scott@example.com", true, true, false, "Mia Scott", "Pass@123", "7896541208", "DeliveryPartner" },
                    { 19, "909 Maple Ave, Boston, MA", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3613), "oliver.hill@example.com", true, true, false, "Oliver Hill", "Pass@123", "7896541209", "DeliveryPartner" },
                    { 20, "111 Willow Way, Charlotte, NC", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3614), "isabella.green@example.com", true, true, false, "Isabella Green", "Pass@123", "7896541210", "DeliveryPartner" },
                    { 21, "1212 Aspen St, Raleigh, NC", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3616), "james.adams@example.com", true, true, false, "James Adams", "Pass@123", "7896541211", "DeliveryPartner" },
                    { 22, "1313 Hickory Ln, Columbus, OH", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3617), "charlotte.perez@example.com", true, true, false, "Charlotte Perez", "Pass@123", "7896541212", "DeliveryPartner" },
                    { 23, "1414 Sycamore Rd, Atlanta, GA", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3619), "henry.turner@example.com", true, true, false, "Henry Turner", "Pass@123", "7896541213", "DeliveryPartner" },
                    { 24, "1515 Magnolia Ct, Richmond, VA", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3621), "amelia.torres@example.com", true, true, false, "Amelia Torres", "Pass@123", "7896541214", "DeliveryPartner" },
                    { 25, "1616 Cherry St, Madison, WI", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3622), "benjamin.ramirez@example.com", true, true, false, "Benjamin Ramirez", "Pass@123", "7896541215", "DeliveryPartner" },
                    { 26, "1717 Chestnut Ave, Omaha, NE", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3624), "evelyn.cox@example.com", true, true, false, "Evelyn Cox", "Pass@123", "7896541216", "DeliveryPartner" },
                    { 27, "1818 Beechwood Dr, Salt Lake City, UT", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3625), "logan.ward@example.com", true, true, false, "Logan Ward", "Pass@123", "7896541217", "DeliveryPartner" },
                    { 28, "1919 Poplar Pl, Kansas City, MO", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3626), "harper.bailey@example.com", true, true, false, "Harper Bailey", "Pass@123", "7896541218", "DeliveryPartner" },
                    { 29, "2020 Olive St, Des Moines, IA", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3628), "sebastian.bell@example.com", true, true, false, "Sebastian Bell", "Pass@123", "7896541219", "DeliveryPartner" },
                    { 30, "2121 Dogwood Blvd, Boise, ID", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3629), "ella.cooper@example.com", true, true, false, "Ella Cooper", "Pass@123", "7896541220", "DeliveryPartner" },
                    { 31, "2222 Hemlock Way, Little Rock, AR", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3631), "jackson.murphy@example.com", true, true, false, "Jackson Murphy", "Pass@123", "7896541221", "DeliveryPartner" },
                    { 32, "2323 Pine Needle Rd, Fargo, ND", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3632), "avery.howard@example.com", true, true, false, "Avery Howard", "Pass@123", "7896541222", "DeliveryPartner" },
                    { 33, "2424 Ivy Ln, Billings, MT", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3637), "daniel.ward@example.com", true, true, false, "Daniel Ward", "Pass@123", "7896541223", "DeliveryPartner" },
                    { 34, "2525 Orchid Dr, Anchorage, AK", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3639), "scarlett.flores@example.com", true, true, false, "Scarlett Flores", "Pass@123", "7896541224", "DeliveryPartner" },
                    { 35, "2626 Tulip Ln, Cheyenne, WY", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3641), "matthew.ross@example.com", true, true, false, "Matthew Ross", "Pass@123", "7896541225", "DeliveryPartner" },
                    { 36, "2727 Daisy St, Helena, MT", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3642), "luna.sanders@example.com", true, true, false, "Luna Sanders", "Pass@123", "7896541226", "DeliveryPartner" },
                    { 37, "2828 Fern Rd, Bismarck, ND", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3644), "david.jenkins@example.com", true, true, false, "David Jenkins", "Pass@123", "7896541227", "DeliveryPartner" },
                    { 38, "2929 Maplewood Ct, Dover, DE", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3645), "chloe.rogers@example.com", true, true, false, "Chloe Rogers", "Pass@123", "7896541228", "DeliveryPartner" },
                    { 39, "3030 Bluebell Rd, Jackson, MS", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3646), "joseph.bryant@example.com", true, true, false, "Joseph Bryant", "Pass@123", "7896541229", "DeliveryPartner" },
                    { 40, "3131 Tulip Hill Dr, Montgomery, AL", new DateTime(2025, 4, 4, 14, 48, 2, 784, DateTimeKind.Local).AddTicks(3648), "grace.hunter@example.com", true, true, false, "Grace Hunter", "Pass@123", "7896541230", "DeliveryPartner" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40);

            migrationBuilder.DropColumn(
                name: "IsAvailble",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(981));
        }
    }
}
