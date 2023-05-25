using Application.UnitTests.Common;
using AutoMapper;
using Booking.Application.Reservations.Queries.GetReservations;
using Booking.Persistance;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Reservation.Queries.GetReservations
{
    [Collection("QueryCollection")]
    public class GetReservationsQueryHandlerTests
    {
        private readonly ReservationDbContext _context;
        private readonly IMapper _mapper;

        public GetReservationsQueryHandlerTests(QueryTestFixtures fixtures)
        {
            _context = fixtures.Context;
            _mapper = fixtures.Mapper;
        }

        [Fact]
        public async Task CanGetReservations()
        {
            var handler = new GetReservationsQueryHandler(_context, _mapper);

            var result = await handler.Handle(new GetReservationsQuery(), CancellationToken.None);

            result.ShouldBeOfType<ReservationsVm>();
            result.Reservations.Count.ShouldBe(4);
        }
    }
}
