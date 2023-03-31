using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                values: new object[] { 1, new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1840), "", new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1858), "", new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1849), "", null, new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1726), 1 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "IsBooked", "Name" },
                values: new object[] { 1, 10, false, "Room1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
