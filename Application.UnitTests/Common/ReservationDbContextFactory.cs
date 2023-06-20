using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using Booking.Persistance;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public static class ReservationDbContextFactory
    {
        public static Mock<ReservationDbContext> Create()
        {
            var dateTime = new DateTime(2023, 6, 20);
            var dateTimeMock = new Mock<IDateTime>();
            dateTimeMock.Setup(m => m.Now).Returns(dateTime);

            var options = new DbContextOptionsBuilder<ReservationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var mock = new Mock<ReservationDbContext>(options, dateTimeMock.Object) { CallBase = true };

            var context = mock.Object;

            context.Database.EnsureCreated();

            var room = new Booking.Domain.Entities.Room()
            {
                Id = 79,
                Name = "Roomtest",
                Capacity = 2,
                IsBooked = false,
                PricePerNight = 200,
                Street = "Kresowa",
                BuildingNumber = 10,
                RoomNumber = 20,
                PostalCode = "212-12",
                City = "Lublin",
                Country = "Polska",
                ImageId = 37
            };
            context.Rooms.Add(room);

            

            var reservation = new Booking.Domain.Entities.Reservation() { 
                Id = 11,
                StartDate = DateTime.Now,
                EndDate = dateTime,
                UserName = "usertest.@gmail.com",
                RoomId = 4 };
            context.Reservations.Add(reservation);

            var reservation2 = new Booking.Domain.Entities.Reservation()
            {
                Id = 123,
                StartDate = DateTime.Now,
                EndDate = dateTime,
                UserName = "usertest2.@gmail.com",
                RoomId = 4
            };
            context.Reservations.Add(reservation2);

            var image = new Booking.Domain.Entities.Image()
            {
                Id = 12,
                PhotoResource = new byte[] { 0x12, 0x34, 0x56, 0x78, 0x9A },
            };
            context.Images.Add(image);

            context.SaveChanges();
            return mock;
        }

        public static void Destroy(ReservationDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
