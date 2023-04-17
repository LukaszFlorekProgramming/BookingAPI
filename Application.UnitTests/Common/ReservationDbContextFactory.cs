using Booking.Application.Interfaces;
using Booking.Persistance;
using Booking.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public static class ReservationDbContextFactory
    {
        public static Mock<ReservationDbContext> Create()
        {
            var dateTime = new DateTime(2000, 1, 1);
            var dateTimeMock = new Mock<IDateTime>();
            dateTimeMock.Setup(m => m.Now).Returns(dateTime);

            var options = new DbContextOptionsBuilder<ReservationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var mock = new Mock<ReservationDbContext>(options, dateTimeMock.Object) { CallBase = true };

            var context = mock.Object;

            context.Database.EnsureCreated();

            var room = new Room() { Id = 4, Capacity = 10, IsBooked = false, Name = "Room4"  };
            context.Rooms.Add(room);

            var reservation = new Booking.Persistance.Entities.Reservation() { Id = 11, RoomId = 4 };
            context.Reservations.Add(reservation);
            

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
