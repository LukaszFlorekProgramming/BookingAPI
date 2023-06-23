using Booking.Application.Interfaces;
using Booking.Domain.Entities;
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

        public UpdateHotelCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }
        public async Task<Hotel> Handle(UpdateHotelCommand request, CancellationToken cancellationToken)
        {
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
