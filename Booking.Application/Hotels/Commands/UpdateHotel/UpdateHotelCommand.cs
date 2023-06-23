using Booking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Commands.UpdateHotel
{
    public class UpdateHotelCommand : IRequest<Hotel>
    {
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; }
        public string Country { get; set; }
    }
}
