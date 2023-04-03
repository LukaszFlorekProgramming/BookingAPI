using Booking.Persistance.Entities;
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
                    Capacity = 10,
                    IsBooked = false
                }, new Room()
                {
                    Id = 2,
                    Name = "Room2",
                    Capacity = 10,
                    IsBooked = false
                },
                new Room()
                {
                    Id = 3,
                    Name = "Room3",
                    Capacity = 10,
                    IsBooked = false
                });
            });

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation()
                {
                    Id = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CreatedBy=string.Empty,
                    Created=DateTime.Now,
                    ModifiedBy=string.Empty,
                    Modified=DateTime.Now,
                    StatusId=1,
                    Inactivated=DateTime.Now,
                    InactivatedBy=string.Empty
                },
                new Reservation()
                {
                    Id = 2,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CreatedBy=string.Empty,
                    Created=DateTime.Now,
                    ModifiedBy=string.Empty,
                    Modified=DateTime.Now,
                    StatusId=1,
                    Inactivated=DateTime.Now,
                    InactivatedBy=string.Empty
                },new Reservation()
                {
                    Id = 3,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CreatedBy=string.Empty,
                    Created=DateTime.Now,
                    ModifiedBy=string.Empty,
                    Modified=DateTime.Now,
                    StatusId=1,
                    Inactivated=DateTime.Now,
                    InactivatedBy=string.Empty
                }
                );
        }
    }
}
