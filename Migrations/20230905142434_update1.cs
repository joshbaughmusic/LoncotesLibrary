using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Checkouts",
                columns: new[] { "Id", "CheckoutDate", "MaterialId", "PatronId", "ReturnDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 5, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1870), 1, 1, new DateTime(2023, 9, 12, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1898) },
                    { 2, new DateTime(2023, 9, 2, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1901), 5, 2, new DateTime(2023, 9, 9, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1903) },
                    { 3, new DateTime(2023, 8, 26, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1905), 10, 3, new DateTime(2023, 9, 3, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1906) },
                    { 4, new DateTime(2023, 8, 29, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1908), 8, 4, new DateTime(2023, 9, 4, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1910) },
                    { 5, new DateTime(2023, 8, 31, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1912), 15, 5, new DateTime(2023, 9, 8, 9, 24, 34, 676, DateTimeKind.Local).AddTicks(1913) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
