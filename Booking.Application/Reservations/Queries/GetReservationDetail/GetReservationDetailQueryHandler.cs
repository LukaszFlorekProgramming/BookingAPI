using Booking.Application.Interfaces;
using MediatR;
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
        public GetReservationDetailQueryHandler(IReservationDbContext roomDbContext) 
        { 
            _context = roomDbContext;
        }
        public async Task<ReservationDetailVm> Handle(GetReservationDetailQuery request, CancellationToken cancellationToken)
        {
            //var reservation = await _context.Res
            throw new NotImplementedException();
        }
    }
}
