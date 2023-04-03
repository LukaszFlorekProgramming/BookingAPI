using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class repair : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 22, 50, 55, 749, DateTimeKind.Local).AddTicks(4100), new DateTime(2023, 4, 3, 22, 50, 55, 749, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 22, 50, 55, 749, DateTimeKind.Local).AddTicks(4103), new DateTime(2023, 4, 3, 22, 50, 55, 749, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 22, 50, 55, 749, DateTimeKind.Local).AddTicks(4106), new DateTime(2023, 4, 3, 22, 50, 55, 749, DateTimeKind.Local).AddTicks(4105) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 21, 43, 11, 691, DateTimeKind.Local).AddTicks(4742), new DateTime(2023, 4, 3, 21, 43, 11, 691, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 21, 43, 11, 691, DateTimeKind.Local).AddTicks(4745), new DateTime(2023, 4, 3, 21, 43, 11, 691, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 21, 43, 11, 691, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 4, 3, 21, 43, 11, 691, DateTimeKind.Local).AddTicks(4747) });
        }
    }
}
