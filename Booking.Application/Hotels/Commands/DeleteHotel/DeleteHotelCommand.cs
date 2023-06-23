using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Commands.DeleteHotel
{
    public class DeleteHotelCommand : IRequest
    {
        public int HotelId { get; set; }
    }
}
