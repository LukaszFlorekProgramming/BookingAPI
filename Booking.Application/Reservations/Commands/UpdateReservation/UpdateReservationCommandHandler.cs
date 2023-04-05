using Booking.Application.Interfaces;
using Booking.Application.Reservations.Commands.CreateReservation;
using Booking.Persistance.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Commands.UpdateReservation
{
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand, Reservation>
    {
        private readonly IReservationDbContext _context;

        public UpdateReservationCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }
        public async Task<Reservation> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            Reservation reservation = new()
            {
                Id = request.Id,
                RoomId = request.RoomId,
                StartDate = request.StartDate,
                EndDate = request.EndDate   
            };

            _context.Reservations.Update(reservation);

            await _context.SaveChangesAsync(cancellationToken);

            return reservation;
        }
    }
}
