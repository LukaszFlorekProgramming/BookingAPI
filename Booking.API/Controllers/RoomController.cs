using Booking.Application.Rooms.Queries.GetRooms;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    [Route("api/rooms")]
    public class RoomController : BaseController
    {
        [HttpGet]
        [Route("GetRooms")]
        public async Task<ActionResult<RoomsVm>> GetRooms()
        {
            var vm = await Mediator.Send(new GetRoomsQuery());
            return vm;
        }
    }
}
