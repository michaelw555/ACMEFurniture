﻿// <auto-generated />
using System;
using GlobalFinanceWebsite.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GlobalFinanceWebsite.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230316191904_migration1")]
    partial class migration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("GlobalFinanceWebsite.Shared.Manfac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Manfac");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Toyota",
                            Url = "toyota"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "aperture",
                            Name = "Tesla",
                            Url = "tesla"
                        });
                });

            modelBuilder.Entity("GlobalFinanceWebsite.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ManfacId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ManfacId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8446),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/2010_Toyota_Corolla_CE%2C_Front_Left.jpg/280px-2010_Toyota_Corolla_CE%2C_Front_Left.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            ManfacId = 1,
                            Model = "2007",
                            Name = "Corolla",
                            Price = 3000m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8479),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/2021_Tesla_Model_3%2C_front_11.10.21.jpg/280px-2021_Tesla_Model_3%2C_front_11.10.21.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            ManfacId = 2,
                            Model = "Model 3",
                            Name = "Tesla",
                            Price = 12000m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8481),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/2018_Tesla_Model_S_75D.jpg/280px-2018_Tesla_Model_S_75D.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            ManfacId = 2,
                            Model = "Model S",
                            Name = "Tesla",
                            Price = 9000m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8521),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/2017_Tesla_Model_X_100D_Front.jpg/280px-2017_Tesla_Model_X_100D_Front.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            ManfacId = 2,
                            Model = "Model X",
                            Name = "Tesla",
                            Price = 15000m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8524),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/2018_Toyota_Camry_%28ASV70R%29_Ascent_sedan_%282018-08-27%29_01.jpg/280px-2018_Toyota_Camry_%28ASV70R%29_Ascent_sedan_%282018-08-27%29_01.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            ManfacId = 1,
                            Model = "2020",
                            Name = "Camry",
                            Price = 3500m,
                            Stock = 25
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8526),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/2022_Toyota_Camry_SE_Standard_Package_in_Celestial_Silver_Metallic%2C_Front_Left.jpg/200px-2022_Toyota_Camry_SE_Standard_Package_in_Celestial_Silver_Metallic%2C_Front_Left.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            ManfacId = 1,
                            Model = "2021",
                            Name = "Camry",
                            Price = 5500m,
                            Stock = 45
                        },
                        new
                        {
                            Id = 7,
                            DateCreated = new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8527),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/2022_Toyota_Camry_Hybrid_XLE_in_Midnight_Black_Metallic%2C_Front_Right%2C_12-25-2021.jpg/200px-2022_Toyota_Camry_Hybrid_XLE_in_Midnight_Black_Metallic%2C_Front_Right%2C_12-25-2021.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            ManfacId = 1,
                            Model = "2022",
                            Name = "Camry",
                            Price = 7500m,
                            Stock = 55
                        },
                        new
                        {
                            Id = 8,
                            DateCreated = new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8529),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Toyota_Vios_XP150_01_China_2014-04-24_%28cropped%29.jpg/280px-Toyota_Vios_XP150_01_China_2014-04-24_%28cropped%29.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            ManfacId = 1,
                            Model = "2014",
                            Name = "Yaris",
                            Price = 3500m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 9,
                            DateCreated = new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8531),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Toyota_Vios_%28XP150%29_1.5_E_front_%28cropped%29.jpg/190px-Toyota_Vios_%28XP150%29_1.5_E_front_%28cropped%29.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            ManfacId = 1,
                            Model = "2017",
                            Name = "Yaris",
                            Price = 3500m,
                            Stock = 20
                        });
                });

            modelBuilder.Entity("GlobalFinanceWebsite.Shared.Product", b =>
                {
                    b.HasOne("GlobalFinanceWebsite.Shared.Manfac", "Manfac")
                        .WithMany("Products")
                        .HasForeignKey("ManfacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manfac");
                });

            modelBuilder.Entity("GlobalFinanceWebsite.Shared.Manfac", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
