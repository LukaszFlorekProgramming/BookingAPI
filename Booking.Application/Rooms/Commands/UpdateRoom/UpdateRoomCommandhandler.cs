using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Commands.UpdateRoom
{
    public class UpdateRoomCommandhandler : IRequestHandler<UpdateRoomCommand, Room>
    {
        private readonly IReservationDbContext _context;

        public UpdateRoomCommandhandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }
        public async Task<Room> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            Room room = new Room()
            {
                Id = request.Id,
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
                ImageId = request.ImageId

            };
            _context.Rooms.Update(room);
            await _context.SaveChangesAsync(cancellationToken);

            return room;
        }
    }
}
