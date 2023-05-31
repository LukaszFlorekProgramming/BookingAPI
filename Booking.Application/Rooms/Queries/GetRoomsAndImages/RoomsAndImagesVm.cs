using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Queries.GetRoomsAndImages
{
    public class RoomsAndImagesVm : IRequest<RoomsAndImagesVm>
    {
        public ICollection<RoomAndImageDto> RoomsAndImages { get; set; }
    }
}
