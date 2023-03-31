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
                values: new object[] { new DateTime(2023, 3, 31, 22, 36, 25, 338, DateTimeKind.Local).AddTicks(255), new DateTime(2023, 3, 31, 22, 36, 25, 338, DateTimeKind.Local).AddTicks(245), new DateTime(2023, 3, 31, 22, 36, 25, 338, DateTimeKind.Local).AddTicks(272), new DateTime(2023, 3, 31, 22, 36, 25, 338, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 3, 31, 22, 36, 25, 338, DateTimeKind.Local).AddTicks(165) });
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
                values: new object[] { new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1840), new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1858), new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1849), new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1726) });
        }
    }
}
