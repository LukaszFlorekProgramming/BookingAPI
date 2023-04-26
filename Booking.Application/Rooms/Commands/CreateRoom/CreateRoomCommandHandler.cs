using Booking.Application.Interfaces;
using Booking.Persistance.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, int>
    {
        private readonly IReservationDbContext _context;

        public CreateRoomCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }
        public async Task<int> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            Room room = new()
            {
                Name = request.Name,
                Capacity = request.Capacity,
                IsBooked = request.IsBooked,
            };

            _context.Rooms.Add(room);

            await _context.SaveChangesAsync(cancellationToken);
            return room.Id;
        }
    }
}
