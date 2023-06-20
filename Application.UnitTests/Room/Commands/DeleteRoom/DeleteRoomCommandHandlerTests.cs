using Application.UnitTests.Common;
using Booking.Application.Reservations.Commands.DeleteReservation;
using Booking.Application.Rooms.Commands.DeleteRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Room.Commands.DeleteRoom
{
    public class DeleteRoomCommandHandlerTests : CommandTestBase
    {
        private readonly DeleteRoomCommandHandler _handler;
        public DeleteRoomCommandHandlerTests() : base()
        {
            _handler = new DeleteRoomCommandHandler(_context);
        }

        [Fact]
        public async Task Handle_GivenValidRequest_ShouldDeleteRoom()
        {
            var command = new DeleteRoomCommand(){ Id = 79 };
            await _handler.Handle(command, CancellationToken.None);
        }
    }
}
