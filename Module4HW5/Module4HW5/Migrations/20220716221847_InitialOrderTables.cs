using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module4HW4.Migrations
{
    public partial class InitialOrderTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderStatusId", "UserId" },
                values: new object[] { 1, new DateTime(2022, 7, 17, 1, 18, 46, 533, DateTimeKind.Local).AddTicks(3891), 1, 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderStatusId", "UserId" },
                values: new object[] { 2, new DateTime(2022, 7, 17, 1, 18, 46, 533, DateTimeKind.Local).AddTicks(3937), 2, 3 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderStatusId", "UserId" },
                values: new object[] { 3, new DateTime(2022, 7, 17, 1, 18, 46, 533, DateTimeKind.Local).AddTicks(3941), 2, 2 });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "OrderId", "Quantity", "TeapotId" },
                values: new object[,]
                {
                    { 1, 1, 3, 1 },
                    { 2, 1, 4, 2 },
                    { 3, 2, 2, 1 },
                    { 4, 3, 9, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
