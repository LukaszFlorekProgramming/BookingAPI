using BlazorBooking.Shared.Models.Room;

namespace BlazorBooking.Client.Services.Room
{
    public interface IRoomService
    {
        Task<RoomsVm> GetRooms();
        Task<RoomDto> CreateRoom(RoomDto roomDto);
        Task DeleteRoom(int roomId);
        Task<RoomDto> UpdateRoom(RoomDto roomDto);
    }
}
