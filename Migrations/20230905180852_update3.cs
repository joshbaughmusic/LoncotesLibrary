using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 9, 5, 13, 8, 52, 354, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 9, 12, 13, 8, 52, 354, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 8, 52, 354, DateTimeKind.Local).AddTicks(8027), new DateTime(2023, 9, 9, 13, 8, 52, 354, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 8, 26, 13, 8, 52, 354, DateTimeKind.Local).AddTicks(8030), null });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 8, 52, 354, DateTimeKind.Local).AddTicks(8032), null });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 8, 31, 13, 8, 52, 354, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 9, 8, 13, 8, 52, 354, DateTimeKind.Local).AddTicks(8035) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
