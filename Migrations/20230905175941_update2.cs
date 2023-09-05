using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 9, 5, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6896), new DateTime(2023, 9, 12, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 9, 2, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6924), new DateTime(2023, 9, 9, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 8, 26, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6927), new DateTime(2023, 9, 3, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 8, 29, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 9, 4, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 8, 31, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6971), new DateTime(2023, 9, 8, 12, 59, 41, 652, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "MaterialTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDays",
                value: 7);

            migrationBuilder.UpdateData(
                table: "MaterialTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDays",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 9, 12, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 9, 2, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1901), new DateTime(2023, 9, 9, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 8, 26, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1905), new DateTime(2023, 9, 3, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 8, 29, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1908), new DateTime(2023, 9, 4, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 8, 31, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1912), new DateTime(2023, 9, 8, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "MaterialTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDays",
                value: 14);

            migrationBuilder.UpdateData(
                table: "MaterialTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDays",
                value: 7);
        }
    }
}
