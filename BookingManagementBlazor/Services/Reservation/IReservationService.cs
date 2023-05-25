using BookingManagementBlazor.Models.Reservation;
using BookingManagementBlazor.Models.Room;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementBlazor.Services.Reservation
{
    public interface IReservationService
    {
        Task<List<ReservationTest>> GetReservations();

        Task<ReservationsVm> GetReservationsBookingAPI();

        Task<ReservationDto> CreateRerservation(ReservationDto reservationDto);
    }
}
