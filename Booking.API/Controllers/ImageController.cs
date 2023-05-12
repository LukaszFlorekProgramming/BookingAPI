using Booking.Application.Images.Commands.CreateImage;
using Booking.Application.Images.Commands.DeleteImage;
using Booking.Application.Images.Queries.GetImages;
using Booking.Application.Reservations.Commands.DeleteReservation;
using Booking.Application.Rooms.Commands.CreateRoom;
using Booking.Application.Rooms.Queries.GetRooms;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    [Route("api/images")]
    public class ImageController : BaseController
    {
        [HttpGet]
        [Route("GetImages")]
        public async Task<ActionResult<ImagesVm>> GetImages()
        {
            var vm = await Mediator.Send(new GetImagesQuery());
            return vm;
        }

        [HttpPost]
        public async Task<IActionResult> CreateImage(CreateImageCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteImage(DeleteImageCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
    }
}
