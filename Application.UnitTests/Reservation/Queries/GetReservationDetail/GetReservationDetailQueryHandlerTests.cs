using Application.UnitTests.Common;
using AutoMapper;
using Booking.Application.Reservations.Queries.GetReservationDetail;
using Booking.Persistance;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Reservation.Queries.GetReservationDetail
{
    [Collection("QueryCollection")]
    public class GetReservationDetailQueryHandlerTests
    {
        private readonly ReservationDbContext _context;
        private readonly IMapper _mapper;
        public GetReservationDetailQueryHandlerTests(QueryTestFixtures fixtures)
        {
            _context = fixtures.Context;
            _mapper = fixtures.Mapper;
        }
        [Fact]

        public async Task CanGetReservationDetailById()
        {
            var handler = new GetReservationDetailQueryHandler(_context, _mapper);
            var reservationId = 11;

            var result = await handler.Handle(new GetReservationDetailQuery { ReservationId = reservationId}, CancellationToken.None);

            result.ShouldBeOfType<ReservationDetailVm>();
            result.RoomId.ShouldBe(4);
        }

    }
}
