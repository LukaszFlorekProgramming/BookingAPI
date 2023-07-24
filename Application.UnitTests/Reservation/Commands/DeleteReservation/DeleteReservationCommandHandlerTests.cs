using Application.UnitTests.Common;
using Booking.Application.Reservations.Commands.CreateReservation;
using Booking.Application.Reservations.Commands.DeleteReservation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Reservation.Commands.DeleteReservation
{
    public class DeleteReservationCommandHandlerTests : CommandTestBase
    {
        private readonly DeleteReservationCommandHandler _handler;
        public DeleteReservationCommandHandlerTests() :base()
        {
            _handler = new DeleteReservationCommandHandler(_context);
        }
        [Fact]
        public async Task Handle_GivenValidRequest_ShouldDeleteReservation()
        {
            var command = new DeleteReservationCommand(){ ReservationId = 11 };
            await _handler.Handle(command, CancellationToken.None);
        }
    }
}
