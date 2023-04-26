using BookingManagementBlazor.Models.Room;

namespace BookingManagementBlazor.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly HttpClient _httpClient;
        public RoomService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<RoomsVm> GetRooms()
        {
            return await _httpClient.GetFromJsonAsync<RoomsVm>("api/rooms/GetRooms");
        }
    }
}
