using BlazorBooking.Shared.Models.Reservation;
using BlazorBooking.Shared.Models.Room;

namespace BlazorBooking.Client.Services.Reservation
{
    public interface IReservationService
    {
        Task<ReservationsVm> GetReservations();
        Task<ReservationDto> CreateRerservation(ReservationDto reservationDto);
        Task DeleteReservation(int id);
        Task<RoomDto> GetRoom(int idRoom);
        Task<byte[]> GetResourseImage(int idImage);
    }
}
