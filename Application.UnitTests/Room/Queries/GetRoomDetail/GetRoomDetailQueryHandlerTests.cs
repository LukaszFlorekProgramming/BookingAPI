using Application.UnitTests.Common;
using AutoMapper;
using Booking.Application.Reservations.Queries.GetReservationDetail;
using Booking.Application.Rooms.Queries.GetRoomDetail;
using Booking.Persistance;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Room.Queries.GetRoomDetail
{
    [Collection("QueryCollection")]
    public class GetRoomDetailQueryHandlerTests
    {
        private readonly ReservationDbContext _context;
        private readonly IMapper _mapper;

        public GetRoomDetailQueryHandlerTests(QueryTestFixtures fixtures)
        {
            _context = fixtures.Context;
            _mapper = fixtures.Mapper;
        }

        [Fact]
        public async Task CanGetRoomDetailById()
        {
            var handler = new GetRoomDetailQueryHandler(_context, _mapper);
            var Id = 79;

            var result = await handler.Handle(new GetRoomDetailQuery { Id = Id }, CancellationToken.None);

            result.ShouldBeOfType<RoomDetailVm>();
            result.IsBooked.ShouldBe(false);
        }
    }
}
