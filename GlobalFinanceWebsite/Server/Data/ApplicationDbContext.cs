using System;
using Microsoft.EntityFrameworkCore;
using GlobalFinanceWebsite.Shared;


namespace GlobalFinanceWebsite.Server.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}
	public DbSet<Product>? Product { get; set; }
    public DbSet<Manfac>? Manfac { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        modelBuilder.Entity<Manfac>().HasData(
                new Manfac { Id = 1, Name = "Toyota", Url = "toyota", Icon = "book" },
                new Manfac { Id = 2, Name = "Tesla", Url = "tesla", Icon = "aperture" });

       modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ManfacId = 1,
                    Name = "Corolla",
                    Model = "2007",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/2010_Toyota_Corolla_CE%2C_Front_Left.jpg/280px-2010_Toyota_Corolla_CE%2C_Front_Left.jpg",
                    Price = 3000m,
                },
                new Product
                {
                    Id = 2,
                    ManfacId = 2,
                    Name = "Tesla",
                    Model = "Model 3",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/2021_Tesla_Model_3%2C_front_11.10.21.jpg/280px-2021_Tesla_Model_3%2C_front_11.10.21.jpg",
                    Price = 12000m,
                },
                new Product
                {
                    Id = 3,
                    ManfacId = 2,
                    Name = "Tesla",
                    Model = "Model S",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/2018_Tesla_Model_S_75D.jpg/280px-2018_Tesla_Model_S_75D.jpg",
                    Price = 9000m,
                },
                new Product
                {
                    Id = 4,
                    ManfacId = 2,
                    Name = "Tesla",
                    Model = "Model X",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/2017_Tesla_Model_X_100D_Front.jpg/280px-2017_Tesla_Model_X_100D_Front.jpg",
                    Price = 15000m,
                },
                new Product
                {
                    Id = 5,
                    ManfacId = 1,
                    Name = "Camry",
                    Model = "2020",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/2018_Toyota_Camry_%28ASV70R%29_Ascent_sedan_%282018-08-27%29_01.jpg/280px-2018_Toyota_Camry_%28ASV70R%29_Ascent_sedan_%282018-08-27%29_01.jpg",
                    Price = 3500m,
                },
                new Product
                {
                    Id = 6,
                    ManfacId = 1,
                    Name = "Camry",
                    Model = "2021",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/2022_Toyota_Camry_SE_Standard_Package_in_Celestial_Silver_Metallic%2C_Front_Left.jpg/200px-2022_Toyota_Camry_SE_Standard_Package_in_Celestial_Silver_Metallic%2C_Front_Left.jpg",
                    Price = 5500m,
                },
                new Product
                {
                    Id = 7,
                    ManfacId = 1,
                    Name = "Camry",
                    Model = "2022",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/2022_Toyota_Camry_Hybrid_XLE_in_Midnight_Black_Metallic%2C_Front_Right%2C_12-25-2021.jpg/200px-2022_Toyota_Camry_Hybrid_XLE_in_Midnight_Black_Metallic%2C_Front_Right%2C_12-25-2021.jpg",
                    Price = 7500m,
                },
                new Product
                {
                    Id = 8,
                    ManfacId = 1,
                    Name = "Yaris",
                    Model = "2014",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Toyota_Vios_XP150_01_China_2014-04-24_%28cropped%29.jpg/280px-Toyota_Vios_XP150_01_China_2014-04-24_%28cropped%29.jpg",
                    Price = 3500m,
                },
                new Product
                {
                    Id = 9,
                    ManfacId = 1,
                    Name = "Yaris",
                    Model = "2017",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Toyota_Vios_%28XP150%29_1.5_E_front_%28cropped%29.jpg/190px-Toyota_Vios_%28XP150%29_1.5_E_front_%28cropped%29.jpg",
                    Price = 3500m,
                });
	}
}

