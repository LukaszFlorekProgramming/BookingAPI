using BlazorBooking.Shared.Models.Reservation;
using BlazorBooking.Shared.Models.Room;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorBooking.Client.Services.Reservation
{
    public class ReservationService : IReservationService
    {
        private readonly HttpClient _httpClient;
        public ReservationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ReservationDto> CreateRerservation(ReservationDto reservationDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/reservations", reservationDto);
            return reservationDto;
        }

        public async Task DeleteReservation(int id)
        {
            var response = await _httpClient.DeleteAsync($"/api/reservations/{id}");
        }

        public async Task<ReservationsVm> GetReservations()
        {
            return await _httpClient.GetFromJsonAsync<ReservationsVm>("api/reservations/GetReservations");
        }

        public async Task<string> GetRoomName(int idRoom)
        {
            var room = await _httpClient.GetFromJsonAsync<RoomDto>($"api/rooms/{idRoom}");
            return room.Name;

        }
    }
}
