using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalFinanceWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8446), 20 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8479), 50 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8481), 50 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8521), 40 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8524), 25 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8526), 45 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8527), 55 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8529), 10 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8531), 20 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5193), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5233), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5236), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5238), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5241), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5244), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5246), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5249), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Stock" },
                values: new object[] { new DateTime(2023, 3, 16, 15, 6, 25, 24, DateTimeKind.Local).AddTicks(5252), 0 });
        }
    }
}
