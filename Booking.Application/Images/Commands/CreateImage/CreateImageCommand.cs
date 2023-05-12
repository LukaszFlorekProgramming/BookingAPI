using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Commands.CreateImage
{
    public class CreateImageCommand : IRequest<int>
    {
        public byte[] PhotoResource { get; set; }
        public int? RoomId { get; set; }
    }
}
