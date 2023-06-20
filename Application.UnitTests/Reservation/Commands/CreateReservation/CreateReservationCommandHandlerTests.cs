using Application.UnitTests.Common;
using Booking.Application.Reservations.Commands.CreateReservation;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Reservation.Commands.CreateReservation
{
    public class CreateReservationCommandHandlerTests : CommandTestBase
    {
        private readonly CreateReservationCommandHandler _handler;
        public CreateReservationCommandHandlerTests() : base()
        {
            _handler = new CreateReservationCommandHandler(_context);
        }

        [Fact]
        public async Task Handle_GivenValidRequest_ShouldInsertReservation()
        {
            var command = new CreateReservationCommand()
            {
                RoomId = 4,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1),
                UserName = "Test"
            };

            var result = await _handler.Handle(command, CancellationToken.None);
            var dir = await _context.Reservations.FirstAsync(x => x.Id == result, CancellationToken.None);

            dir.ShouldNotBeNull();
        }
    }
}
