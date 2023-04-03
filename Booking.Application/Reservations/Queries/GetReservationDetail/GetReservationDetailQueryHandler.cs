using Booking.Application.Interfaces;
using Booking.Persistance.Entities;
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
        public GetReservationDetailQueryHandler(IReservationDbContext reservationDbContext) 
        { 
            _context = reservationDbContext;
        }
        public async Task<ReservationDetailVm> Handle(GetReservationDetailQuery request, CancellationToken cancellationToken)
        {
            var reservation = await _context.Reservations.Where(x => x.Id == request.ReservationId).FirstOrDefaultAsync(cancellationToken);
            var reservationVm = new ReservationDetailVm()
            {
                RoomId = reservation.RoomId.Value
            };

            return reservationVm;
        }
    }
}
