using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dutch_Treat.Migrations
{
    public partial class SeedOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber" },
                values: new object[] { 1, new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "12345" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
