using BlazorBooking.Shared.Models.Reservation;

namespace BlazorBooking.Client.Services.Reservation
{
    public interface IReservationService
    {

        Task<ReservationsVm> GetReservations();

        Task<ReservationDto> CreateRerservation(ReservationDto reservationDto);
        Task DeleteReservation(int id);
        Task<string> GetRoomName(int idRoom);
    }
}
