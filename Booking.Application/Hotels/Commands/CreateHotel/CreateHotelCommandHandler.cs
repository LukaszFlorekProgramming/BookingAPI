using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Booking.Application.Hotels.Commands.CreateHotel
{
    public class CreateHotelCommandHandler : IRequestHandler<CreateHotelCommand, int>
    {
        private readonly IReservationDbContext _context;
        private readonly IValidator<CreateHotelCommand> _validator;

        public CreateHotelCommandHandler(IReservationDbContext reservationDbContext, IValidator<CreateHotelCommand> validator)
        {
            _context = reservationDbContext;
            _validator = validator;
        }
        public async Task<int> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            Hotel hotel = new()
            {
                Name = request.Name,
                City = request.City,
                Country = request.Country
            };

            _context.Hotels.Add(hotel);

            await _context.SaveChangesAsync(cancellationToken);
            return hotel.HotelId;
        }
    }
}
