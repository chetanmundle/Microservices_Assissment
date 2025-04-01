using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeliveryService.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
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
                    { 1, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2690), true, true, false, "John", "5698745892" },
                    { 2, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2704), true, true, false, "Alice", "6589741235" },
                    { 3, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2705), true, true, false, "Michael", "7458963214" },
                    { 4, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2707), true, true, false, "Emma", "8523697415" },
                    { 5, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2708), true, true, false, "Robert", "9632587416" },
                    { 6, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2811), true, true, false, "Sophia", "7418529635" },
                    { 7, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2814), true, true, false, "William", "1597534862" },
                    { 8, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2815), true, true, false, "Olivia", "3571598246" },
                    { 9, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2816), true, true, false, "James", "2589631475" },
                    { 10, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2818), true, true, false, "Isabella", "3698521475" },
                    { 11, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2819), true, true, false, "Benjamin", "4561237895" },
                    { 12, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2820), true, true, false, "Mia", "7896541236" },
                    { 13, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2821), true, true, false, "Daniel", "8527419635" },
                    { 14, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2821), true, true, false, "Charlotte", "7419638521" },
                    { 15, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2822), true, true, false, "Elijah", "7531596248" },
                    { 16, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2823), true, true, false, "Amelia", "8523579516" },
                    { 17, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2824), true, true, false, "Henry", "9517538524" },
                    { 18, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2832), true, true, false, "Harper", "7894561239" },
                    { 19, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2834), true, true, false, "Lucas", "9514263875" },
                    { 20, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2835), true, true, false, "Evelyn", "3652147895" },
                    { 21, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2837), true, true, false, "Mason", "1247896352" },
                    { 22, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2838), true, true, false, "Avery", "6985741325" },
                    { 23, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2839), true, true, false, "Logan", "3574126985" },
                    { 24, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2840), true, true, false, "Scarlett", "7895236147" },
                    { 25, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2841), true, true, false, "Ethan", "4126985732" },
                    { 26, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2842), true, true, false, "Abigail", "7896523145" },
                    { 27, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2843), true, true, false, "Alexander", "1236985742" },
                    { 28, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2843), true, true, false, "Grace", "6987415236" },
                    { 29, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2844), true, true, false, "Jack", "2143658796" },
                    { 30, new DateTime(2025, 4, 1, 17, 22, 5, 383, DateTimeKind.Local).AddTicks(2845), true, true, false, "Ella", "9874563215" }
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
