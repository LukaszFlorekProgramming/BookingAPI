using BlazorBooking.Shared.Models.Image;
using BlazorBooking.Shared.Models.Room;
using System.Net.Http.Json;

namespace BlazorBooking.Client.Services.Room
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
        public async Task DeleteRoom(int roomId)
        {
            var response = await _httpClient.DeleteAsync($"/api/rooms/{roomId}");
        }
        public async Task<RoomDto> UpdateRoom(RoomDto roomDto)
        {
            var response = await _httpClient.PutAsJsonAsync("api/rooms", roomDto);
            return roomDto;
        }
        public async Task<RoomDto> GetRoomDetails(int id)
        {
            return await _httpClient.GetFromJsonAsync<RoomDto>($"api/rooms/{id}");
        }
        public async Task<byte[]> GetResourseImage(int idImage)
        {
            var image = await _httpClient.GetFromJsonAsync<ImageDto>($"api/images/{idImage}");
            return image.PhotoResource;
        }
        public async Task<RoomsAndImagesVm> GetRoomWithPhoto()
        {
            return await _httpClient.GetFromJsonAsync<RoomsAndImagesVm>("api/roomsandimages/GetRoomsWithPhotos");
        }
    }
}
