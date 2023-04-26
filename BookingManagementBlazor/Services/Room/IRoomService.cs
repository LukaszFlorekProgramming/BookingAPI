using BookingManagementBlazor.Models.Room;

namespace BookingManagementBlazor.Services.Room
{
    public interface IRoomService
    {
        Task<RoomsVm> GetRooms();
    }
}
