using AutoMapper;
using Booking.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Queries.GetReservationDetail
{
    public class GetReservationDetailQueryHandler : IRequestHandler<GetReservationDetailQuery, ReservationDetailVm>
    {
        private readonly IReservationDbContext _context;
        private IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;
        public GetReservationDetailQueryHandler(IReservationDbContext reservationDbContext, IMapper mapper, ICurrentUserService userService) 
        { 
            _context = reservationDbContext;
            _mapper = mapper;
            _currentUserService = userService;
        }
        public async Task<ReservationDetailVm> Handle(GetReservationDetailQuery request, CancellationToken cancellationToken)
        {
            var reservation = await _context.Reservations.Include(x => x.Room).Where(x => x.Id == request.ReservationId).FirstOrDefaultAsync(cancellationToken);
            var reservationVm = _mapper.Map<ReservationDetailVm>(reservation);

            return reservationVm;
        }
    }
}
