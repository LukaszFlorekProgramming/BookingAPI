using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class addImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoResource = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 11, 19, 12, 36, 947, DateTimeKind.Local).AddTicks(6994), new DateTime(2023, 5, 11, 19, 12, 36, 947, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 11, 19, 12, 36, 947, DateTimeKind.Local).AddTicks(6999), new DateTime(2023, 5, 11, 19, 12, 36, 947, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 11, 19, 12, 36, 947, DateTimeKind.Local).AddTicks(7002), new DateTime(2023, 5, 11, 19, 12, 36, 947, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.CreateIndex(
                name: "IX_Images_RoomId",
                table: "Images",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

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
        }
    }
}
