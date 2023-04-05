using Booking.Application.Reservations.Commands.CreateReservation;
using Booking.Application.Reservations.Commands.DeleteReservation;
using Booking.Application.Reservations.Commands.UpdateReservation;
using Booking.Application.Reservations.Queries.GetReservationDetail;
using Booking.Application.Reservations.Queries.GetReservations;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    [Route("api/reservations")]
    public class ReservationController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<ReservationsVm>> GetReservations()
        {
            var vm = await Mediator.Send(new GetReservationsQuery());
            return vm;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationDetailVm>> GetReservationDetails(int id)
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
        [HttpPut]
        public async Task<IActionResult> UpdateReservation(UpdateReservationCommand command)
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
