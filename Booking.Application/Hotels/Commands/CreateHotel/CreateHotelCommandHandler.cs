using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Commands.CreateHotel
{
    public class CreateHotelCommandHandler : IRequestHandler<CreateHotelCommand, int>
    {
        private readonly IReservationDbContext _context;
        public CreateHotelCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }
        public async Task<int> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
        {
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
