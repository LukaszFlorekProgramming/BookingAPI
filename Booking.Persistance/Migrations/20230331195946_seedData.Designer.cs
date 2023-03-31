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
    [Migration("20230331195946_seedData")]
    partial class seedData
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

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1840),
                            CreatedBy = "",
                            EndDate = new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1832),
                            Inactivated = new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1858),
                            InactivatedBy = "",
                            Modified = new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1849),
                            ModifiedBy = "",
                            StartDate = new DateTime(2023, 3, 31, 21, 59, 45, 806, DateTimeKind.Local).AddTicks(1726),
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("Booking.Persistance.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 10,
                            IsBooked = false,
                            Name = "Room1"
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
