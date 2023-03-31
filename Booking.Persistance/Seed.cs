using Booking.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Persistance
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
                    Capacity = 10,
                    IsBooked = false
                });
            });

            modelBuilder.Entity<Reservation>(d =>
            {
                d.HasData(new Reservation()
                {
                    Id = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CreatedBy = string.Empty,
                    Created = DateTime.Now,
                    ModifiedBy = string.Empty,
                    Modified = DateTime.Now,
                    StatusId = 1,
                    InactivatedBy = string.Empty,
                    Inactivated = DateTime.Now
                });

            });
        }
    }
}
