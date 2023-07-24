using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Commands.CreateHotel
{
    public class CreateHotelCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
        public string City { get; set; }
        public string Country { get; set; }
    }
}
