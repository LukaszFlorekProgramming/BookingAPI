using AutoMapper;
using Booking.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Queries.GetRoomDetail
{
    public class GetRoomDetailQueryHandler : IRequestHandler<GetRoomDetailQuery, RoomDetailVm>
    {
        private readonly IReservationDbContext _context;
        private IMapper _mapper;
        public GetRoomDetailQueryHandler(IReservationDbContext reservationDbContext, IMapper mapper)
        {
            _context = reservationDbContext;
            _mapper = mapper;
        }
        public async Task<RoomDetailVm> Handle(GetRoomDetailQuery request, CancellationToken cancellationToken)
        {
            var room = await _context.Rooms.Where(x => x.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            var roomVm = _mapper.Map<RoomDetailVm>(room);

            return roomVm;
        }
    }
}
