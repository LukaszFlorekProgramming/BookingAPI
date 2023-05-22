using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddIdUserReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reservations");

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "EndDate", "RoomId", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 16, 19, 15, 55, 229, DateTimeKind.Local).AddTicks(5809), null, new DateTime(2023, 5, 16, 19, 15, 55, 229, DateTimeKind.Local).AddTicks(5772) },
                    { 2, new DateTime(2023, 5, 16, 19, 15, 55, 229, DateTimeKind.Local).AddTicks(5812), null, new DateTime(2023, 5, 16, 19, 15, 55, 229, DateTimeKind.Local).AddTicks(5811) },
                    { 3, new DateTime(2023, 5, 16, 19, 15, 55, 229, DateTimeKind.Local).AddTicks(5815), null, new DateTime(2023, 5, 16, 19, 15, 55, 229, DateTimeKind.Local).AddTicks(5814) }
                });
        }
    }
}
