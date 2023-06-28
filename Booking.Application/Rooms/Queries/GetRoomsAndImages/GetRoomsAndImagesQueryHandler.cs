using AutoMapper;
using AutoMapper.QueryableExtensions;
using Booking.Application.Interfaces;
using Booking.Application.Rooms.Queries.GetRooms;
using Booking.Application.Rooms.Queries.GetRoomsAndImage;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Queries.GetRoomsAndImages
{
    public class GetRoomsAndImagesQueryHandler : IRequestHandler<GetRoomsAndImagesQuery, RoomsAndImagesVm>
    {
        private readonly IReservationDbContext _context;
        private IMapper _mapper;

        public GetRoomsAndImagesQueryHandler(IReservationDbContext reservationDbContext, IMapper mapper)
        {
            _context = reservationDbContext;
            _mapper = mapper;
        }

        public async Task<RoomsAndImagesVm> Handle(GetRoomsAndImagesQuery request, CancellationToken cancellationToken)
        {
            var RoomsAndImages = await _context.Rooms.Include(x => x.Hotel).ProjectTo<RoomAndImageDto>(_mapper.ConfigurationProvider).ToListAsync();

            return new RoomsAndImagesVm() { RoomsAndImages = RoomsAndImages };
        }
    }
}
