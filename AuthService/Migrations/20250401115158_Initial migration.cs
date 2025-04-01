using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthService.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
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
                columns: new[] { "UserId", "Address", "CreatedDate", "Email", "IsActive", "IsDeleted", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "123 Main St, New York, NY", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(954), "chetanmundlesd@gmail.com", true, false, "Chetan Mundle", "Pass@123" },
                    { 2, "456 Elm St, Los Angeles, CA", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(969), "alice.brown@example.com", true, false, "Alice Brown", "Pass@123" },
                    { 3, "789 Pine Ave, Chicago, IL", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(970), "michael.smith@example.com", true, false, "Michael Smith", "Pass@123" },
                    { 4, "321 Oak St, Houston, TX", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(971), "emma.davis@example.com", true, false, "Emma Davis", "Pass@123" },
                    { 5, "654 Maple Rd, Phoenix, AZ", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(972), "robert.wilson@example.com", true, false, "Robert Wilson", "Pass@123" },
                    { 6, "987 Birch Blvd, Philadelphia, PA", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(976), "sophia.miller@example.com", true, false, "Sophia Miller", "Pass@123" },
                    { 7, "246 Cedar St, San Antonio, TX", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(977), "william.johnson@example.com", true, false, "William Johnson", "Pass@123" },
                    { 8, "135 Spruce Dr, San Diego, CA", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(978), "olivia.martinez@example.com", true, false, "Olivia Martinez", "Pass@123" },
                    { 9, "753 Aspen Way, Dallas, TX", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(979), "james.anderson@example.com", true, false, "James Anderson", "Pass@123" },
                    { 10, "852 Redwood Ct, San Jose, CA", new DateTime(2025, 4, 1, 17, 21, 57, 777, DateTimeKind.Local).AddTicks(981), "isabella.thompson@example.com", true, false, "Isabella Thompson", "Pass@123" }
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
