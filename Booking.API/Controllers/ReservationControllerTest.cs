using Booking.API.Data;
using Booking.Application.Reservations.Commands.CreateReservation;
using Booking.Application.Reservations.Commands.DeleteReservation;
using Booking.Application.Reservations.Commands.UpdateReservation;
using Booking.Application.Reservations.Queries.GetReservationDetail;
using Booking.Application.Reservations.Queries.GetReservations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Collections.Generic;

namespace Booking.API.Controllers
{
    [Route("api/reservationsTest")]
    public class ReservationControllerTest : BaseController
    {
        //public List<ReservationsVm> list = new List<ReservationsVm>();
        /*public ActionResult<ReservationsVm> ListaReservationsVm;
        public List<ReservationsVm> lista = new List<ReservationsVm>();*/
        
        [HttpGet]
        [Route("GetReservations")]
        public async Task<ActionResult<ReservationsVm>> GetReservations()
        {
            List<ReservationTest> reservations = new List<ReservationTest>();
            reservations.Add(new ReservationTest {Id=1,Name="testName1" });
            reservations.Add(new ReservationTest { Id=2, Name="testName2" });
            reservations.Add(new ReservationTest { Id=3, Name="testName3" });
            return Ok(reservations);
        }
        /*[HttpGet("{id}")]
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
        }*/

    }
}
