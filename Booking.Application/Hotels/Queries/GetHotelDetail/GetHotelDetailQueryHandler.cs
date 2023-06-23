using AutoMapper;
using Booking.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Queries.GetHotelDetail
{
    public class GetHotelDetailQueryHandler : IRequestHandler<GetHotelDetailQuery, HotelDetailVm>
    {
        private readonly IReservationDbContext _context;
        private IMapper _mapper;

        public GetHotelDetailQueryHandler(IReservationDbContext reservationDbContext, IMapper mapper)
        {
            _context = reservationDbContext;
            _mapper = mapper;
        }
        public async Task<HotelDetailVm> Handle(GetHotelDetailQuery request, CancellationToken cancellationToken)
        {
            var hotel = await _context.Hotels.Where(x => x.HotelId == request.HotelId).FirstOrDefaultAsync(cancellationToken);
            var hotelVm = _mapper.Map<HotelDetailVm>(hotel);
            return hotelVm;
        }
    }
}
