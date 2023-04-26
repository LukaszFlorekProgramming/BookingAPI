using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Queries.GetRooms
{
    public class RoomsVm
    {
        public ICollection<RoomDto> Rooms { get; set; }
    }
}
