using Booking.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Commands.DeleteHotel
{
    public class DeleteHotelCommandHandler : IRequestHandler<DeleteHotelCommand>
    {
        private readonly IReservationDbContext _context;
        public DeleteHotelCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }
        public async Task Handle(DeleteHotelCommand request, CancellationToken cancellationToken)
        {
            var room = await _context.Hotels.Where(x => x.HotelId == request.HotelId).FirstOrDefaultAsync();
            _context.Hotels.Remove(room);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
