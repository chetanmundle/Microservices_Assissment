﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantService.Data;

#nullable disable

namespace RestaurantService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantService.Entities.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuItemId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("MenuItemId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            MenuItemId = 1,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3630),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Gulab Jamun",
                            Price = 100m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 2,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3633),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Paneer Butter Masala",
                            Price = 250m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 3,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3635),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Chicken Biryani",
                            Price = 300m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 4,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3636),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Mutton Rogan Josh",
                            Price = 350m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 5,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3637),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Dal Makhani",
                            Price = 180m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 6,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3642),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Butter Naan",
                            Price = 50m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 7,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3643),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Masala Dosa",
                            Price = 120m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 8,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3644),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Idli Sambar",
                            Price = 90m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 9,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3645),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Tandoori Chicken",
                            Price = 400m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 10,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3647),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Fish Curry",
                            Price = 320m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 11,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3649),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Veg Pulao",
                            Price = 160m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 12,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3650),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Rajma Chawal",
                            Price = 170m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 13,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3651),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Aloo Paratha",
                            Price = 80m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 14,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3652),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Malai Kofta",
                            Price = 230m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 15,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3653),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Shahi Paneer",
                            Price = 260m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 16,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3655),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Chole Bhature",
                            Price = 150m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 17,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3656),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Chicken Tikka Masala",
                            Price = 310m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 18,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3658),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Prawn Curry",
                            Price = 370m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 19,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3659),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Mushroom Masala",
                            Price = 210m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 20,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3661),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Egg Curry",
                            Price = 200m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 21,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3662),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Hakka Noodles",
                            Price = 140m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 22,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3663),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Spring Rolls",
                            Price = 130m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 23,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3664),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Chicken Manchurian",
                            Price = 270m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 24,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3666),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Veg Manchurian",
                            Price = 190m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 25,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3667),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Mutton Keema",
                            Price = 330m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 26,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3668),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Bhindi Masala",
                            Price = 160m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 27,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3669),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Dal Tadka",
                            Price = 170m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 28,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3670),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Kadhai Paneer",
                            Price = 250m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 29,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3672),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Jeera Rice",
                            Price = 120m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 30,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3673),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Chocolate Brownie",
                            Price = 180m,
                            RestaurantId = 1
                        });
                });

            modelBuilder.Entity("RestaurantService.Entities.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            CreatedDate = new DateTime(2025, 4, 6, 18, 47, 13, 384, DateTimeKind.Local).AddTicks(3516),
                            IsActive = true,
                            IsDeleted = false,
                            RestaurantName = "Arav Dhaba"
                        });
                });

            modelBuilder.Entity("RestaurantService.Entities.MenuItem", b =>
                {
                    b.HasOne("RestaurantService.Entities.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });
#pragma warning restore 612, 618
        }
    }
}
