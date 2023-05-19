﻿// <auto-generated />
using System;
using Booking.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Booking.Persistance.Migrations
{
    [DbContext(typeof(ReservationDbContext))]
    [Migration("20230510120823_UpdatePersistanceRoom")]
    partial class UpdatePersistanceRoom
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Booking.Persistance.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9369),
                            StartDate = new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9328)
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9374),
                            StartDate = new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9373)
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9379),
                            StartDate = new DateTime(2023, 5, 10, 14, 8, 23, 342, DateTimeKind.Local).AddTicks(9377)
                        });
                });

            modelBuilder.Entity("Booking.Persistance.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildingNumber")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("float");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuildingNumber = 1,
                            Capacity = 1,
                            City = "Lublin",
                            Country = "Polska",
                            IsBooked = false,
                            Name = "Room1",
                            PostalCode = "10-203",
                            PricePerNight = 10.0,
                            RoomNumber = 1,
                            Street = "Kresowa"
                        },
                        new
                        {
                            Id = 2,
                            BuildingNumber = 2,
                            Capacity = 2,
                            City = "Lublin",
                            Country = "Polska",
                            IsBooked = false,
                            Name = "Room2",
                            PostalCode = "10-203",
                            PricePerNight = 12.0,
                            RoomNumber = 2,
                            Street = "Kresowa"
                        },
                        new
                        {
                            Id = 3,
                            BuildingNumber = 3,
                            Capacity = 3,
                            City = "Lublin",
                            Country = "Polska",
                            IsBooked = false,
                            Name = "Room3",
                            PostalCode = "10-203",
                            PricePerNight = 13.0,
                            RoomNumber = 3,
                            Street = "Kresowa"
                        });
                });

            modelBuilder.Entity("Booking.Persistance.Entities.Reservation", b =>
                {
                    b.HasOne("Booking.Persistance.Entities.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Booking.Persistance.Entities.Room", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}