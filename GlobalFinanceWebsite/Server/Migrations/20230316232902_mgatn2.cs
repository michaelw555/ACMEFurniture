using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalFinanceWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class mgatn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 3, 16, 19, 19, 4, 643, DateTimeKind.Local).AddTicks(8531));
        }
    }
}
