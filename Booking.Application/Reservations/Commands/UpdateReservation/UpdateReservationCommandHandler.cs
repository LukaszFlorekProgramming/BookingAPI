using Booking.Application.Interfaces;
using Booking.Application.Reservations.Commands.CreateReservation;
using Booking.Domain.Entities;
using FluentValidation;
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
        private readonly IValidator<UpdateReservationCommand> _validator;

        public UpdateReservationCommandHandler(IReservationDbContext reservationDbContext, IValidator<UpdateReservationCommand> validator)
        {
            _context = reservationDbContext;
            _validator = validator;
        }
        public async Task<Reservation> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            Reservation reservation = new()
            {
                Id = request.Id,
                RoomId = request.RoomId,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                UserName = request.UserName
            };
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync(cancellationToken);

            return reservation;
        }
    }
}
