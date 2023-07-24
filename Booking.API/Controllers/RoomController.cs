using Booking.Application.Reservations.Commands.CreateReservation;
using Booking.Application.Reservations.Commands.DeleteReservation;
using Booking.Application.Reservations.Commands.UpdateReservation;
using Booking.Application.Reservations.Queries.GetReservationDetail;
using Booking.Application.Rooms.Commands.CreateRoom;
using Booking.Application.Rooms.Commands.DeleteRoom;
using Booking.Application.Rooms.Commands.UpdateRoom;
using Booking.Application.Rooms.Queries.GetRoomDetail;
using Booking.Application.Rooms.Queries.GetRooms;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomDetailVm>> GetRoomDetails(int id)
        {
            var vm = await Mediator.Send(new GetRoomDetailQuery() { Id = id });
            return vm;
        }
        [HttpPost]
        public async Task<IActionResult> CreateRoom(CreateRoomCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRoom(UpdateRoomCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRoom(DeleteRoomCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomByID(int id)
        {
            await Mediator.Send(new DeleteRoomCommand() { Id = id });
            return Ok();
        }
    }
}
