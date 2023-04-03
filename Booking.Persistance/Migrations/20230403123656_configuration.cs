using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "EndDate", "Inactivated", "Modified", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3736), new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3734), new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3740), new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3737), new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "EndDate", "Inactivated", "Modified", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3745), new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3743), new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3748), new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3746), new DateTime(2023, 4, 3, 14, 36, 56, 261, DateTimeKind.Local).AddTicks(3742) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "EndDate", "Inactivated", "Modified", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5514), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5511), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5518), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "EndDate", "Inactivated", "Modified", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5524), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 4, 3, 14, 7, 41, 888, DateTimeKind.Local).AddTicks(5521) });
        }
    }
}
