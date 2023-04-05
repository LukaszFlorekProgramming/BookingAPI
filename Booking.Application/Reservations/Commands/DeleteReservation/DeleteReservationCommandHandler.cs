using Booking.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Commands.DeleteReservation
{
    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand>
    {
        private readonly IReservationDbContext _context;

        
        public DeleteReservationCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }

        public async Task Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
        {
            var reservation = await _context.Reservations.Where(x => x.Id == request.ReservationId).FirstOrDefaultAsync(cancellationToken);
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
