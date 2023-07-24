using BlazorBooking.Shared.Models.Hotel;
using System.Net.Http.Json;

namespace BlazorBooking.Client.Services.Hotel
{
    public class HotelService : IHotelService
    {
        private readonly HttpClient _httpClient;
        public HotelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HotelDto> CreateHotel(HotelDto hotelDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/hotels", hotelDto);
            return hotelDto;
        }
        public async Task DeleteHotel(int id)
        {
            var response = await _httpClient.DeleteAsync($"/api/hotels/{id}");
        }
        public async Task<HotelDto> GetHotel(int id)
        {
            return await _httpClient.GetFromJsonAsync<HotelDto>($"api/hotels/{id}");
        }
        public async Task<HotelsVm> GetHotels()
        {
            return await _httpClient.GetFromJsonAsync<HotelsVm>("api/hotels/GetHotels");
        }
        public async Task<HotelDto> UpdateRoom(HotelDto hotelDto)
        {
            var response = await _httpClient.PutAsJsonAsync("api/hotels", hotelDto);
            return hotelDto;
        }
    }
}
