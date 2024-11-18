﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nimap.Models;

#nullable disable

namespace Nimap.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nimap.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Electronics"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Books"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Clothing"
                        });
                });

            modelBuilder.Entity("Nimap.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2,
                            ProductName = "Product 1"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 3,
                            ProductName = "Product 2"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            ProductName = "Product 3"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            ProductName = "Product 4"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            ProductName = "Product 5"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            ProductName = "Product 6"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2,
                            ProductName = "Product 7"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            ProductName = "Product 8"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1,
                            ProductName = "Product 9"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 2,
                            ProductName = "Product 10"
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 3,
                            ProductName = "Product 11"
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 1,
                            ProductName = "Product 12"
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 2,
                            ProductName = "Product 13"
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 3,
                            ProductName = "Product 14"
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 1,
                            ProductName = "Product 15"
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 2,
                            ProductName = "Product 16"
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 3,
                            ProductName = "Product 17"
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 1,
                            ProductName = "Product 18"
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 2,
                            ProductName = "Product 19"
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryId = 3,
                            ProductName = "Product 20"
                        },
                        new
                        {
                            ProductId = 21,
                            CategoryId = 1,
                            ProductName = "Product 21"
                        },
                        new
                        {
                            ProductId = 22,
                            CategoryId = 2,
                            ProductName = "Product 22"
                        },
                        new
                        {
                            ProductId = 23,
                            CategoryId = 3,
                            ProductName = "Product 23"
                        },
                        new
                        {
                            ProductId = 24,
                            CategoryId = 1,
                            ProductName = "Product 24"
                        },
                        new
                        {
                            ProductId = 25,
                            CategoryId = 2,
                            ProductName = "Product 25"
                        },
                        new
                        {
                            ProductId = 26,
                            CategoryId = 3,
                            ProductName = "Product 26"
                        },
                        new
                        {
                            ProductId = 27,
                            CategoryId = 1,
                            ProductName = "Product 27"
                        },
                        new
                        {
                            ProductId = 28,
                            CategoryId = 2,
                            ProductName = "Product 28"
                        },
                        new
                        {
                            ProductId = 29,
                            CategoryId = 3,
                            ProductName = "Product 29"
                        },
                        new
                        {
                            ProductId = 30,
                            CategoryId = 1,
                            ProductName = "Product 30"
                        },
                        new
                        {
                            ProductId = 31,
                            CategoryId = 2,
                            ProductName = "Product 31"
                        },
                        new
                        {
                            ProductId = 32,
                            CategoryId = 3,
                            ProductName = "Product 32"
                        },
                        new
                        {
                            ProductId = 33,
                            CategoryId = 1,
                            ProductName = "Product 33"
                        },
                        new
                        {
                            ProductId = 34,
                            CategoryId = 2,
                            ProductName = "Product 34"
                        },
                        new
                        {
                            ProductId = 35,
                            CategoryId = 3,
                            ProductName = "Product 35"
                        },
                        new
                        {
                            ProductId = 36,
                            CategoryId = 1,
                            ProductName = "Product 36"
                        },
                        new
                        {
                            ProductId = 37,
                            CategoryId = 2,
                            ProductName = "Product 37"
                        },
                        new
                        {
                            ProductId = 38,
                            CategoryId = 3,
                            ProductName = "Product 38"
                        },
                        new
                        {
                            ProductId = 39,
                            CategoryId = 1,
                            ProductName = "Product 39"
                        },
                        new
                        {
                            ProductId = 40,
                            CategoryId = 2,
                            ProductName = "Product 40"
                        },
                        new
                        {
                            ProductId = 41,
                            CategoryId = 3,
                            ProductName = "Product 41"
                        },
                        new
                        {
                            ProductId = 42,
                            CategoryId = 1,
                            ProductName = "Product 42"
                        },
                        new
                        {
                            ProductId = 43,
                            CategoryId = 2,
                            ProductName = "Product 43"
                        },
                        new
                        {
                            ProductId = 44,
                            CategoryId = 3,
                            ProductName = "Product 44"
                        },
                        new
                        {
                            ProductId = 45,
                            CategoryId = 1,
                            ProductName = "Product 45"
                        },
                        new
                        {
                            ProductId = 46,
                            CategoryId = 2,
                            ProductName = "Product 46"
                        },
                        new
                        {
                            ProductId = 47,
                            CategoryId = 3,
                            ProductName = "Product 47"
                        },
                        new
                        {
                            ProductId = 48,
                            CategoryId = 1,
                            ProductName = "Product 48"
                        },
                        new
                        {
                            ProductId = 49,
                            CategoryId = 2,
                            ProductName = "Product 49"
                        },
                        new
                        {
                            ProductId = 50,
                            CategoryId = 3,
                            ProductName = "Product 50"
                        },
                        new
                        {
                            ProductId = 51,
                            CategoryId = 1,
                            ProductName = "Product 51"
                        },
                        new
                        {
                            ProductId = 52,
                            CategoryId = 2,
                            ProductName = "Product 52"
                        },
                        new
                        {
                            ProductId = 53,
                            CategoryId = 3,
                            ProductName = "Product 53"
                        },
                        new
                        {
                            ProductId = 54,
                            CategoryId = 1,
                            ProductName = "Product 54"
                        },
                        new
                        {
                            ProductId = 55,
                            CategoryId = 2,
                            ProductName = "Product 55"
                        },
                        new
                        {
                            ProductId = 56,
                            CategoryId = 3,
                            ProductName = "Product 56"
                        },
                        new
                        {
                            ProductId = 57,
                            CategoryId = 1,
                            ProductName = "Product 57"
                        },
                        new
                        {
                            ProductId = 58,
                            CategoryId = 2,
                            ProductName = "Product 58"
                        },
                        new
                        {
                            ProductId = 59,
                            CategoryId = 3,
                            ProductName = "Product 59"
                        },
                        new
                        {
                            ProductId = 60,
                            CategoryId = 1,
                            ProductName = "Product 60"
                        },
                        new
                        {
                            ProductId = 61,
                            CategoryId = 2,
                            ProductName = "Product 61"
                        },
                        new
                        {
                            ProductId = 62,
                            CategoryId = 3,
                            ProductName = "Product 62"
                        },
                        new
                        {
                            ProductId = 63,
                            CategoryId = 1,
                            ProductName = "Product 63"
                        },
                        new
                        {
                            ProductId = 64,
                            CategoryId = 2,
                            ProductName = "Product 64"
                        },
                        new
                        {
                            ProductId = 65,
                            CategoryId = 3,
                            ProductName = "Product 65"
                        },
                        new
                        {
                            ProductId = 66,
                            CategoryId = 1,
                            ProductName = "Product 66"
                        },
                        new
                        {
                            ProductId = 67,
                            CategoryId = 2,
                            ProductName = "Product 67"
                        },
                        new
                        {
                            ProductId = 68,
                            CategoryId = 3,
                            ProductName = "Product 68"
                        },
                        new
                        {
                            ProductId = 69,
                            CategoryId = 1,
                            ProductName = "Product 69"
                        },
                        new
                        {
                            ProductId = 70,
                            CategoryId = 2,
                            ProductName = "Product 70"
                        },
                        new
                        {
                            ProductId = 71,
                            CategoryId = 3,
                            ProductName = "Product 71"
                        },
                        new
                        {
                            ProductId = 72,
                            CategoryId = 1,
                            ProductName = "Product 72"
                        },
                        new
                        {
                            ProductId = 73,
                            CategoryId = 2,
                            ProductName = "Product 73"
                        },
                        new
                        {
                            ProductId = 74,
                            CategoryId = 3,
                            ProductName = "Product 74"
                        },
                        new
                        {
                            ProductId = 75,
                            CategoryId = 1,
                            ProductName = "Product 75"
                        },
                        new
                        {
                            ProductId = 76,
                            CategoryId = 2,
                            ProductName = "Product 76"
                        },
                        new
                        {
                            ProductId = 77,
                            CategoryId = 3,
                            ProductName = "Product 77"
                        },
                        new
                        {
                            ProductId = 78,
                            CategoryId = 1,
                            ProductName = "Product 78"
                        },
                        new
                        {
                            ProductId = 79,
                            CategoryId = 2,
                            ProductName = "Product 79"
                        },
                        new
                        {
                            ProductId = 80,
                            CategoryId = 3,
                            ProductName = "Product 80"
                        },
                        new
                        {
                            ProductId = 81,
                            CategoryId = 1,
                            ProductName = "Product 81"
                        },
                        new
                        {
                            ProductId = 82,
                            CategoryId = 2,
                            ProductName = "Product 82"
                        },
                        new
                        {
                            ProductId = 83,
                            CategoryId = 3,
                            ProductName = "Product 83"
                        },
                        new
                        {
                            ProductId = 84,
                            CategoryId = 1,
                            ProductName = "Product 84"
                        },
                        new
                        {
                            ProductId = 85,
                            CategoryId = 2,
                            ProductName = "Product 85"
                        },
                        new
                        {
                            ProductId = 86,
                            CategoryId = 3,
                            ProductName = "Product 86"
                        },
                        new
                        {
                            ProductId = 87,
                            CategoryId = 1,
                            ProductName = "Product 87"
                        },
                        new
                        {
                            ProductId = 88,
                            CategoryId = 2,
                            ProductName = "Product 88"
                        },
                        new
                        {
                            ProductId = 89,
                            CategoryId = 3,
                            ProductName = "Product 89"
                        },
                        new
                        {
                            ProductId = 90,
                            CategoryId = 1,
                            ProductName = "Product 90"
                        },
                        new
                        {
                            ProductId = 91,
                            CategoryId = 2,
                            ProductName = "Product 91"
                        },
                        new
                        {
                            ProductId = 92,
                            CategoryId = 3,
                            ProductName = "Product 92"
                        },
                        new
                        {
                            ProductId = 93,
                            CategoryId = 1,
                            ProductName = "Product 93"
                        },
                        new
                        {
                            ProductId = 94,
                            CategoryId = 2,
                            ProductName = "Product 94"
                        },
                        new
                        {
                            ProductId = 95,
                            CategoryId = 3,
                            ProductName = "Product 95"
                        },
                        new
                        {
                            ProductId = 96,
                            CategoryId = 1,
                            ProductName = "Product 96"
                        },
                        new
                        {
                            ProductId = 97,
                            CategoryId = 2,
                            ProductName = "Product 97"
                        },
                        new
                        {
                            ProductId = 98,
                            CategoryId = 3,
                            ProductName = "Product 98"
                        },
                        new
                        {
                            ProductId = 99,
                            CategoryId = 1,
                            ProductName = "Product 99"
                        },
                        new
                        {
                            ProductId = 100,
                            CategoryId = 2,
                            ProductName = "Product 100"
                        });
                });

            modelBuilder.Entity("Nimap.Models.Product", b =>
                {
                    b.HasOne("Nimap.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Nimap.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}