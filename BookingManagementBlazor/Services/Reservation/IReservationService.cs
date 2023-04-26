using BookingManagementBlazor.Models.Reservation;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementBlazor.Services.Reservation
{
    public interface IReservationService
    {
        Task<List<ReservationTest>> GetReservations();

        Task<ReservationsVm> GetReservationsBookingAPI();
    }
}
