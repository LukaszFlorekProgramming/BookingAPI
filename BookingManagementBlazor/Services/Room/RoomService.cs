using BookingManagementBlazor.Models.Room;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BookingManagementBlazor.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly HttpClient _httpClient;
        public RoomService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RoomDto> CreateRoom(RoomDto roomDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/rooms", roomDto);
            return roomDto;
        }

        public async Task<RoomsVm> GetRooms()
        {
            return await _httpClient.GetFromJsonAsync<RoomsVm>("api/rooms/GetRooms");
        }
        
    }
}
