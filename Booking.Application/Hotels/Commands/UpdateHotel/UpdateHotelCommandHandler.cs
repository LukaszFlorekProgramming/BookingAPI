using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Commands.UpdateHotel
{
    public class UpdateHotelCommandHandler : IRequestHandler<UpdateHotelCommand, Hotel>
    {
        private readonly IReservationDbContext _context;
        private readonly IValidator<UpdateHotelCommand> _validator;

        public UpdateHotelCommandHandler(IReservationDbContext reservationDbContext, IValidator<UpdateHotelCommand> validator)
        {
            _context = reservationDbContext;
            _validator = validator;
        }
        public async Task<Hotel> Handle(UpdateHotelCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            Hotel hotel = new()
            {
                HotelId = request.HotelId,
                Name = request.Name,
                City = request.City,
                Country = request.Country
            };
            _context.Hotels.Update(hotel);
            await _context.SaveChangesAsync(cancellationToken);
            return hotel;
        }
    }
}
