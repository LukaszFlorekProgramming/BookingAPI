using Application.UnitTests.Common;
using Booking.Application.Rooms.Commands.CreateRoom;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Room.Commands.CreateRoom
{
    public class CreateRoomCommandHandlerTests : CommandTestBase
    {
        private readonly CreateRoomCommandHandler _handler;
        public CreateRoomCommandHandlerTests() : base()
        {
            _handler = new CreateRoomCommandHandler(_context);
        }

        [Fact]
        public async Task Handle_GivenValidRequest_ShouldInsertRoom()
        {
            var command = new CreateRoomCommand()
            {
                Name = "RoomTest",
                Capacity = 1,
                IsBooked = false,
                PricePerNight = 10,
                Street = "Kresowa",
                BuildingNumber = 1,
                RoomNumber = 1,
                PostalCode = "10-203",
                City = "Lublin",
                Country = "Polska"
            };
            var result = await _handler.Handle(command, CancellationToken.None);
            var dir = await _context.Rooms.FirstAsync(x => x.Id == result, CancellationToken.None);

            dir.ShouldNotBeNull();
        }
    }
}
