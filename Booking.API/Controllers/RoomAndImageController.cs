using Booking.Application.Rooms.Queries.GetRooms;
using Booking.Application.Rooms.Queries.GetRoomsAndImage;
using Booking.Application.Rooms.Queries.GetRoomsAndImages;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    [Route("api/roomsandimages")]
    public class RoomAndImageController : BaseController
    {
        [HttpGet]
        [Route("GetRoomsWithPhotos")]
        public async Task<ActionResult<RoomsAndImagesVm>> GetRooms()
        {
            var vm = await Mediator.Send(new GetRoomsAndImagesQuery());
            return vm;
        }
    }
}
