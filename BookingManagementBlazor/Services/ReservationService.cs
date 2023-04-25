using BookingManagementBlazor.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementBlazor.Services
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
    }
}
