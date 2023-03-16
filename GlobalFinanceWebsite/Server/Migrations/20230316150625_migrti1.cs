using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GlobalFinanceWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class migrti1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manfac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manfac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ManfacId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Manfac_ManfacId",
                        column: x => x.ManfacId,
                        principalTable: "Manfac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Manfac",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "book", "Toyota", "toyota" },
                    { 2, "aperture", "Tesla", "tesla" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Image", "IsDeleted", "IsPublic", "ManfacId", "Model", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5193), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/2010_Toyota_Corolla_CE%2C_Front_Left.jpg/280px-2010_Toyota_Corolla_CE%2C_Front_Left.jpg", false, false, 1, "2007", "Corolla", 3000m, 0 },
                    { 2, new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5233), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/2021_Tesla_Model_3%2C_front_11.10.21.jpg/280px-2021_Tesla_Model_3%2C_front_11.10.21.jpg", false, false, 2, "Model 3", "Tesla", 12000m, 0 },
                    { 3, new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5236), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/2018_Tesla_Model_S_75D.jpg/280px-2018_Tesla_Model_S_75D.jpg", false, false, 2, "Model S", "Tesla", 9000m, 0 },
                    { 4, new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5238), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/2017_Tesla_Model_X_100D_Front.jpg/280px-2017_Tesla_Model_X_100D_Front.jpg", false, false, 2, "Model X", "Tesla", 15000m, 0 },
                    { 5, new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5241), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/2018_Toyota_Camry_%28ASV70R%29_Ascent_sedan_%282018-08-27%29_01.jpg/280px-2018_Toyota_Camry_%28ASV70R%29_Ascent_sedan_%282018-08-27%29_01.jpg", false, false, 1, "2020", "Camry", 3500m, 0 },
                    { 6, new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5244), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/2022_Toyota_Camry_SE_Standard_Package_in_Celestial_Silver_Metallic%2C_Front_Left.jpg/200px-2022_Toyota_Camry_SE_Standard_Package_in_Celestial_Silver_Metallic%2C_Front_Left.jpg", false, false, 1, "2021", "Camry", 5500m, 0 },
                    { 7, new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5246), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/2022_Toyota_Camry_Hybrid_XLE_in_Midnight_Black_Metallic%2C_Front_Right%2C_12-25-2021.jpg/200px-2022_Toyota_Camry_Hybrid_XLE_in_Midnight_Black_Metallic%2C_Front_Right%2C_12-25-2021.jpg", false, false, 1, "2022", "Camry", 7500m, 0 },
                    { 8, new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5249), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Toyota_Vios_XP150_01_China_2014-04-24_%28cropped%29.jpg/280px-Toyota_Vios_XP150_01_China_2014-04-24_%28cropped%29.jpg", false, false, 1, "2014", "Yaris", 3500m, 0 },
                    { 9, new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Toyota_Vios_%28XP150%29_1.5_E_front_%28cropped%29.jpg/190px-Toyota_Vios_%28XP150%29_1.5_E_front_%28cropped%29.jpg", false, false, 1, "2017", "Yaris", 3500m, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ManfacId",
                table: "Product",
                column: "ManfacId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Manfac");
        }
    }
}
