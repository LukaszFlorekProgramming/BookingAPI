using Application.UnitTests.Common;
using AutoMapper;
using Booking.Application.Reservations.Queries.GetReservations;
using Booking.Application.Rooms.Queries.GetRoomDetail;
using Booking.Application.Rooms.Queries.GetRooms;
using Booking.Persistance;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Room.Queries.GetRooms
{
    [Collection("QueryCollection")]
    public class GetRoomsQueryHandlerTests
    {
        private readonly ReservationDbContext _context;
        private readonly IMapper _mapper;
        public GetRoomsQueryHandlerTests(QueryTestFixtures fixtures)
        {
            _context = fixtures.Context;
            _mapper = fixtures.Mapper;
        }

        [Fact]
        public async Task CanGetRooms()
        {
            var handler = new GetRoomsQueryHandler(_context, _mapper);

            var result = await handler.Handle(new GetRoomsQuery(), CancellationToken.None);

            result.ShouldBeOfType<RoomsVm>();
            result.Rooms.Count.ShouldBe(4);
        }
    }
}
