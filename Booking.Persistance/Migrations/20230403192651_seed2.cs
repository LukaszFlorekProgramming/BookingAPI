using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "EndDate", "Inactivated", "Modified", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(939), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(938), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(945), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(941), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "EndDate", "Inactivated", "Modified", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(950), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(949), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(953), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(952), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Created", "CreatedBy", "EndDate", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RoomId", "StartDate", "StatusId" },
                values: new object[] { 3, new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(958), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(956), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(960), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(959), "", null, new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(955), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
