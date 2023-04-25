using BookingManagementBlazor.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementBlazor.Services
{
    public interface IReservationService
    {
        Task<List<ReservationTest>> GetReservations();

        Task<ReservationsVm> GetReservationsBookingAPI();
    }
}
