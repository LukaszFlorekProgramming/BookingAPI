using BlazorBooking.Shared.Models.Image;

namespace BlazorBooking.Client.Services.Image
{
    public interface IImageService
    {
        Task<ImageVm> GetImages();
        Task<ImageDto> CreateImage(ImageDto imageDto);
        //Task DeleteImage(ImageDto imageDto);
        Task<int> DeleteImage(int id);
    }
}
