using Booking.Application.Rooms.Queries.GetRoomsAndImages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Queries.GetRoomsAndImage
{
    public class GetRoomsAndImagesQuery : IRequest<RoomsAndImagesVm>
    {
    }
}
