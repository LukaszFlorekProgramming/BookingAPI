using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using FluentValidation;
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
        private readonly IValidator<CreateRoomCommand> _validator;
        public CreateRoomCommandHandler(IReservationDbContext reservationDbContext, IValidator<CreateRoomCommand> validator)
        {
            _context = reservationDbContext;
            _validator = validator;
        }
        public async Task<int> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            Room room = new()
            {
                Name = request.Name,
                Capacity = request.Capacity,
                IsBooked = request.IsBooked,
                PricePerNight = request.PricePerNight,
                Street = request.Street,
                BuildingNumber = request.BuildingNumber,
                RoomNumber = request.RoomNumber,
                PostalCode = request.PostalCode,
                City = request.City,
                Country = request.Country,
                ImageId = request.ImageId,
                HotelId = request.HotelId
            };
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync(cancellationToken);

            return room.Id;
        }
    }
}
