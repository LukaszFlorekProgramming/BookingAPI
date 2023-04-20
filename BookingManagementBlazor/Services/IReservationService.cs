using BookingManagementBlazor.Data;

namespace BookingManagementBlazor.Services
{
    public interface IReservationService
    {
        Task<List<ReservationTest>> GetReservations();
    }
}
