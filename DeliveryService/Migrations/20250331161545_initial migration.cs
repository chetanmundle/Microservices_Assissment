using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeliveryService.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    DeliveryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    DeliveryPersonId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.DeliveryId);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryPersons",
                columns: table => new
                {
                    DeliveryPersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPersons", x => x.DeliveryPersonId);
                });

            migrationBuilder.InsertData(
                table: "DeliveryPersons",
                columns: new[] { "DeliveryPersonId", "CreatedDate", "IsActive", "IsAvailable", "IsDeleted", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 31, 21, 45, 44, 885, DateTimeKind.Local).AddTicks(5764), true, true, false, "John M", "1234567890" },
                    { 2, new DateTime(2025, 3, 31, 21, 45, 44, 885, DateTimeKind.Local).AddTicks(5820), true, true, false, "Melon ", "2342356743" },
                    { 3, new DateTime(2025, 3, 31, 21, 45, 44, 885, DateTimeKind.Local).AddTicks(5845), true, true, false, "Keloni S T ", "7684635238" },
                    { 4, new DateTime(2025, 3, 31, 21, 45, 44, 885, DateTimeKind.Local).AddTicks(5866), true, true, false, "Mr. R L", "0983727843" },
                    { 5, new DateTime(2025, 3, 31, 21, 45, 44, 885, DateTimeKind.Local).AddTicks(5888), true, true, false, "Steno Dev", "8378394384" },
                    { 6, new DateTime(2025, 3, 31, 21, 45, 44, 885, DateTimeKind.Local).AddTicks(5914), true, true, false, "John M", "1234567890" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "DeliveryPersons");
        }
    }
}
