using Booking.Application.Reservations.Commands.CreateReservation;
using Booking.Application.Reservations.Commands.DeleteReservation;
using Booking.Application.Reservations.Queries.GetReservationDetail;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    [Route("api/reservations")]
    public class ReservationController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetReservationDetailQuery() { ReservationId = id });
            return vm;
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteReservation(DeleteReservationCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }

    }
}
