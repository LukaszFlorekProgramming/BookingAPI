using AutoMapper;
using AutoMapper.QueryableExtensions;
using Booking.Application.Interfaces;
using Booking.Persistance.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Queries.GetReservations
{
    public class GetReservationsQueryHandler : IRequestHandler<GetReservationsQuery, ReservationsVm>
    {
        private readonly IReservationDbContext _context;
        private IMapper _mapper;
        public GetReservationsQueryHandler(IReservationDbContext reservationDbContext, IMapper mapper)
        {
            _context = reservationDbContext;
            _mapper = mapper;
        }
        public async Task<ReservationsVm> Handle(GetReservationsQuery getReservationsQuery, CancellationToken none)
        {
            var reservations = await _context.Reservations.AsNoTracking().ProjectTo<ReservationDto>(_mapper.ConfigurationProvider).ToListAsync();

            return new ReservationsVm() { Reservations = reservations };
        }
    }
}
