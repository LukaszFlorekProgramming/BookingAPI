using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public bool IsBooked { get; set; }
    }
}
