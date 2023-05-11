using BookingManagementBlazor.Models.Reservation;
using BookingManagementBlazor.Models.Room;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementBlazor.Services.Reservation
{
    public class ReservationService : IReservationService
    {
        private readonly HttpClient _httpClient;
        public ReservationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ReservationTest>> GetReservations()
        {
            return await _httpClient.GetFromJsonAsync<List<ReservationTest>>("api/reservationsTest/GetReservations");
        }
        public async Task<ReservationsVm> GetReservationsBookingAPI()
        {
            return await _httpClient.GetFromJsonAsync<ReservationsVm>("api/reservations/GetReservations");
        }

        public async Task<ReservationDto> CreateRerservation(ReservationDto reservationDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/reservations", reservationDto);
            return reservationDto;
        }
    }
}
