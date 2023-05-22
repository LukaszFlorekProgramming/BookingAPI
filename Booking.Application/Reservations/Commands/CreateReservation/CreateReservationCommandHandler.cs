using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Commands.CreateReservation
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, int>
    {
        private readonly IReservationDbContext _context;
        
        public CreateReservationCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }
        public async Task<int> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            Reservation reservation = new()
            {
                RoomId = request.RoomId,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                UserName = request.UserName
                
            };

            _context.Reservations.Add(reservation);

            await _context.SaveChangesAsync(cancellationToken);

            return reservation.Id;

        }
    }
}
