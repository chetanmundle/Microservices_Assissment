using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantService.Migrations
{
    /// <inheritdoc />
    public partial class initial_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItems_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "CreatedDate", "IsActive", "IsDeleted", "RestaurantName" },
                values: new object[] { 1, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3516), true, false, "Arav Dhaba" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedDate", "IsActive", "IsDeleted", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3630), true, false, "Gulab Jamun", 100m, 1 },
                    { 2, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3633), true, false, "Paneer Butter Masala", 250m, 1 },
                    { 3, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3635), true, false, "Chicken Biryani", 300m, 1 },
                    { 4, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3636), true, false, "Mutton Rogan Josh", 350m, 1 },
                    { 5, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3637), true, false, "Dal Makhani", 180m, 1 },
                    { 6, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3642), true, false, "Butter Naan", 50m, 1 },
                    { 7, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3643), true, false, "Masala Dosa", 120m, 1 },
                    { 8, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3644), true, false, "Idli Sambar", 90m, 1 },
                    { 9, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3645), true, false, "Tandoori Chicken", 400m, 1 },
                    { 10, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3647), true, false, "Fish Curry", 320m, 1 },
                    { 11, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3649), true, false, "Veg Pulao", 160m, 1 },
                    { 12, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3650), true, false, "Rajma Chawal", 170m, 1 },
                    { 13, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3651), true, false, "Aloo Paratha", 80m, 1 },
                    { 14, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3652), true, false, "Malai Kofta", 230m, 1 },
                    { 15, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3653), true, false, "Shahi Paneer", 260m, 1 },
                    { 16, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3655), true, false, "Chole Bhature", 150m, 1 },
                    { 17, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3656), true, false, "Chicken Tikka Masala", 310m, 1 },
                    { 18, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3658), true, false, "Prawn Curry", 370m, 1 },
                    { 19, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3659), true, false, "Mushroom Masala", 210m, 1 },
                    { 20, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3661), true, false, "Egg Curry", 200m, 1 },
                    { 21, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3662), true, false, "Hakka Noodles", 140m, 1 },
                    { 22, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3663), true, false, "Spring Rolls", 130m, 1 },
                    { 23, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3664), true, false, "Chicken Manchurian", 270m, 1 },
                    { 24, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3666), true, false, "Veg Manchurian", 190m, 1 },
                    { 25, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3667), true, false, "Mutton Keema", 330m, 1 },
                    { 26, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3668), true, false, "Bhindi Masala", 160m, 1 },
                    { 27, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3669), true, false, "Dal Tadka", 170m, 1 },
                    { 28, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3670), true, false, "Kadhai Paneer", 250m, 1 },
                    { 29, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3672), true, false, "Jeera Rice", 120m, 1 },
                    { 30, new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3673), true, false, "Chocolate Brownie", 180m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_RestaurantId",
                table: "MenuItems",
                column: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
