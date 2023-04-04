using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsBooked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "EndDate", "RoomId", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 4, 19, 47, 9, 877, DateTimeKind.Local).AddTicks(1735), null, new DateTime(2023, 4, 4, 19, 47, 9, 877, DateTimeKind.Local).AddTicks(1661) },
                    { 2, new DateTime(2023, 4, 4, 19, 47, 9, 877, DateTimeKind.Local).AddTicks(1743), null, new DateTime(2023, 4, 4, 19, 47, 9, 877, DateTimeKind.Local).AddTicks(1740) },
                    { 3, new DateTime(2023, 4, 4, 19, 47, 9, 877, DateTimeKind.Local).AddTicks(1751), null, new DateTime(2023, 4, 4, 19, 47, 9, 877, DateTimeKind.Local).AddTicks(1748) }
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

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
