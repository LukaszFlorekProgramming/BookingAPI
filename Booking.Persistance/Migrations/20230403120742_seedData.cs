using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Created", "CreatedBy", "EndDate", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RoomId", "StartDate", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5514), "", new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5511), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5518), "", new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5516), "", null, new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5474), 1 },
                    { 2, new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5524), "", new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5527), "", new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5525), "", null, new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5521), 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "IsBooked", "Name" },
                values: new object[,]
                {
                    { 1, 10, false, "Room1" },
                    { 2, 10, false, "Room2" },
                    { 3, 10, false, "Room3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
