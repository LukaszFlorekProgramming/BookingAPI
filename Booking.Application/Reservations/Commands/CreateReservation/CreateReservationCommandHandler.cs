using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using FluentValidation;
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
        private readonly IValidator<CreateReservationCommand> _validator;
        
        public CreateReservationCommandHandler(IReservationDbContext reservationDbContext, IValidator<CreateReservationCommand> validator)
        {
            _context = reservationDbContext;
            _validator = validator;
        }
        public async Task<int> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

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
