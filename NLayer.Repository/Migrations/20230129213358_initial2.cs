using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 33, 58, 490, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 33, 58, 490, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 33, 58, 490, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 33, 58, 490, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 33, 58, 490, DateTimeKind.Local).AddTicks(1625));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 28, 13, 197, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 28, 13, 197, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 28, 13, 197, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 28, 13, 197, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 0, 28, 13, 197, DateTimeKind.Local).AddTicks(5401));
        }
    }
}
