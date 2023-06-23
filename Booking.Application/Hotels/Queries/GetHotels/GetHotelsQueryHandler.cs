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

namespace Booking.Application.Hotels.Queries.GetHotels
{
    public class GetHotelsQueryHandler : IRequestHandler<GetHotelsQuery, HotelsVm>
    {
        private readonly IReservationDbContext _context;
        private IMapper _mapper;

        public GetHotelsQueryHandler(IReservationDbContext reservationDbContext, IMapper mapper)
        {
            _context = reservationDbContext;
            _mapper = mapper;
        }
        public async Task<HotelsVm> Handle(GetHotelsQuery request, CancellationToken cancellationToken)
        {
            var hotels = await _context.Hotels.AsNoTracking().ProjectTo<HotelDto>(_mapper.ConfigurationProvider).ToListAsync();
            return new HotelsVm { Hotels = hotels };
        }
    }
}
