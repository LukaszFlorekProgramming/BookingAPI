using Application.UnitTests.Common;
using AutoMapper;
using AutoMapper.Features;
using Booking.Application.Reservations.Commands.CreateReservation;
using Booking.Application.Reservations.Commands.UpdateReservation;
using Booking.Application.Reservations.Queries.GetReservationDetail;
using Booking.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Reservation.Commands.UpdateReservation
{
    public class UpdateReservationCommandHandlerTests : CommandTestBase
    {
        private readonly UpdateReservationCommandHandler _handler;

        public UpdateReservationCommandHandlerTests() : base()
        {
            _handler = new UpdateReservationCommandHandler(_context);
        }

        [Fact]
        public async Task Handle_GivenValidRequest_ShouldUpdateReservation()
        {
            var command = new UpdateReservationCommand()
            {
                Id = 123,
                RoomId = 4,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1),
                UserName = "Test2"
            };
            var result = await _handler.Handle(command, CancellationToken.None);
            var dir = await _context.Reservations.FirstAsync(x => x.Id == 11, CancellationToken.None);
            dir.ShouldNotBeNull();
            dir.UserName.ShouldBe("Test2");
        }
    }
}
