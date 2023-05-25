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
                    IsBooked = table.Column<bool>(type: "bit", nullable: false),
                    PricePerNight = table.Column<double>(type: "float", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    { 1, new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5584), null, new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5546) },
                    { 2, new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5587), null, new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5586) },
                    { 3, new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5590), null, new DateTime(2023, 5, 10, 13, 23, 43, 321, DateTimeKind.Local).AddTicks(5589) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BuildingNumber", "Capacity", "City", "Country", "IsBooked", "Name", "PostalCode", "PricePerNight", "RoomNumber", "Street" },
                values: new object[,]
                {
                    { 1, "10", 1, "Lublin", "Polska", false, "Room1", "10-203", 10.0, "1", "Kresowa" },
                    { 2, "11", 2, "Lublin", "Polska", false, "Room2", "10-203", 12.0, "1", "Kresowa" },
                    { 3, "13", 3, "Lublin", "Polska", false, "Room3", "10-203", 13.0, "1", "Kresowa" }
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
