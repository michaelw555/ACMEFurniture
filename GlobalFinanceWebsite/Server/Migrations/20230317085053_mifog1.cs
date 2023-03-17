using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalFinanceWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class mifog1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pinfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fname = table.Column<string>(type: "TEXT", nullable: false),
                    Lname = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Deposit = table.Column<decimal>(type: "TEXT", nullable: false),
                    Months = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pinfo", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 17, 8, 50, 53, 122, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 17, 8, 50, 53, 122, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 17, 8, 50, 53, 122, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 3, 17, 8, 50, 53, 122, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 3, 17, 8, 50, 53, 122, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 3, 17, 8, 50, 53, 122, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 3, 17, 8, 50, 53, 122, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 3, 17, 8, 50, 53, 122, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 3, 17, 8, 50, 53, 122, DateTimeKind.Local).AddTicks(3203));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pinfo");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 23, 29, 1, 993, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 23, 29, 1, 993, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 23, 29, 1, 993, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 23, 29, 1, 993, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 23, 29, 1, 993, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 23, 29, 1, 993, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 23, 29, 1, 993, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 23, 29, 1, 993, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 23, 29, 1, 993, DateTimeKind.Local).AddTicks(8113));
        }
    }
}
