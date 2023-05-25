using AutoMapper;
using AutoMapper.QueryableExtensions;
using Booking.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Queries.GetRooms
{
    public class GetRoomsQueryHandler : IRequestHandler<GetRoomsQuery, RoomsVm>
    {
        private readonly IReservationDbContext _context;
        private IMapper _mapper;

        public GetRoomsQueryHandler(IReservationDbContext reservationDbContext, IMapper mapper)
        {
            _context = reservationDbContext;
            _mapper = mapper;
        }

        public async Task<RoomsVm> Handle(GetRoomsQuery request, CancellationToken cancellationToken)
        {
            var rooms = await _context.Rooms.AsNoTracking().ProjectTo<RoomDto>(_mapper.ConfigurationProvider).ToListAsync();

            return new RoomsVm() { Rooms = rooms };
        }
    }
}
