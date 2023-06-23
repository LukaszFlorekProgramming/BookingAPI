using Booking.Application.Hotels.Commands.CreateHotel;
using Booking.Application.Hotels.Commands.DeleteHotel;
using Booking.Application.Hotels.Commands.UpdateHotel;
using Booking.Application.Hotels.Queries.GetHotelDetail;
using Booking.Application.Hotels.Queries.GetHotels;
using Booking.Application.Reservations.Commands.CreateReservation;
using Booking.Application.Reservations.Commands.DeleteReservation;
using Booking.Application.Reservations.Commands.UpdateReservation;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    [Route("api/hotels")]
    public class HotelController : BaseController
    {
        [HttpGet]
        [Route("GetHotels")]
        public async Task<ActionResult<HotelsVm>> GetHotels()
        {
            var vm = await Mediator.Send(new GetHotelsQuery());
            return vm;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelDetailVm>> GetHotelDetail(int id)
        {
            var vm = await Mediator.Send(new GetHotelDetailQuery() { HotelId = id });
            return vm;
        }
        [HttpPost]
        public async Task<IActionResult> CreateHotel(CreateHotelCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateHotel(UpdateHotelCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteHotel(DeleteHotelCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelByID(int id)
        {
            await Mediator.Send(new DeleteHotelCommand() { HotelId = id });
            return Ok();
        }
    }
}
