using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersistanceRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoomNumber",
                table: "Rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingNumber",
                table: "Rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9369), new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9374), new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9379), new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNumber", "RoomNumber" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNumber", "RoomNumber" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNumber", "RoomNumber" },
                values: new object[] { 3, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BuildingNumber",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNumber", "RoomNumber" },
                values: new object[] { "10", "1" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNumber", "RoomNumber" },
                values: new object[] { "11", "1" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNumber", "RoomNumber" },
                values: new object[] { "13", "1" });
        }
    }
}
