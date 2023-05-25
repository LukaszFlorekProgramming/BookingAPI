using Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Persistance.Migrations
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(d =>
            {
                d.HasData(new Room()
                {
                    Id = 1,
                    Name = "Room1",
                    Capacity = 1,
                    IsBooked = false,
                    PricePerNight = 10,
                    Street = "Kresowa",
                    BuildingNumber = 1,
                    RoomNumber = 1,
                    PostalCode = "10-203",
                    City = "Lublin",
                    Country = "Polska"
                },
                new Room()
                {
                    Id = 2,
                    Name = "Room2",
                    Capacity = 2,
                    IsBooked = false,
                    PricePerNight = 12,
                    Street = "Kresowa",
                    BuildingNumber = 2,
                    RoomNumber = 2,
                    PostalCode = "10-203",
                    City = "Lublin",
                    Country = "Polska"
                },
                new Room()
                {
                    Id = 3,
                    Name = "Room3",
                    Capacity = 3,
                    IsBooked = false,
                    PricePerNight = 13,
                    Street = "Kresowa",
                    BuildingNumber = 3,
                    RoomNumber = 3,
                    PostalCode = "10-203",
                    City = "Lublin",
                    Country = "Polska"
                }
                );
            });

            /*modelBuilder.Entity<Reservation>().HasData(
                new Reservation()
                {
                    Id = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    
                },
                new Reservation()
                {
                    Id = 2,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    
                },new Reservation()
                {
                    Id = 3,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }
                );*/
        }
    }
}
