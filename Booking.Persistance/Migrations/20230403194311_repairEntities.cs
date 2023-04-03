using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class repairEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Reservations");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "Reservations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Reservations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "EndDate", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StartDate", "StatusId" },
                values: new object[] { new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(939), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(938), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(945), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(941), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(903), 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "EndDate", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StartDate", "StatusId" },
                values: new object[] { new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(950), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(949), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(953), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(952), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(948), 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "EndDate", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StartDate", "StatusId" },
                values: new object[] { new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(958), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(956), new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(960), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(959), "", new DateTime(2023, 4, 3, 21, 26, 51, 108, DateTimeKind.Local).AddTicks(955), 1 });
        }
    }
}
