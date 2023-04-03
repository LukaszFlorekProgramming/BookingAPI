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
        
    }
}
