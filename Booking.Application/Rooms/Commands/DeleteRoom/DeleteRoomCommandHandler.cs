using Booking.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Commands.DeleteRoom
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand>
    {
        private readonly IReservationDbContext _context;
        public DeleteRoomCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }
        public async Task Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            var room = await _context.Rooms.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
