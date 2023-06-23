using BlazorBooking.Shared.Models.Hotel;

namespace BlazorBooking.Client.Services.Hotel
{
    public interface IHotelService
    {
        Task<HotelsVm> GetHotels();
        Task<HotelDto> GetHotel(int id);
        Task<HotelDto> CreateHotel(HotelDto hotelDto);
        Task DeleteHotel(int id);
        Task<HotelDto> UpdateRoom(HotelDto hotelDto);
    }
}
