using BlazorBooking.Shared.Models.Room;
using System.Threading.Tasks;

namespace BlazorBooking.Client.Services.Room
{
    public interface IRoomService
    {
        Task<RoomsVm> GetRooms();
        Task<RoomDto> CreateRoom(RoomDto roomDto);
        Task DeleteRoom(int roomId);
        Task<RoomDto> UpdateRoom(RoomDto roomDto);
        Task<RoomDto> GetRoomDetails(int id);
        Task<byte[]> GetResourseImage(int idImage);
    }
}
