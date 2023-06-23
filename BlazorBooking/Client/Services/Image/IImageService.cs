using BlazorBooking.Shared.Models.Image;

namespace BlazorBooking.Client.Services.Image
{
    public interface IImageService
    {
        Task<ImagesVm> GetImages();
        Task<ImageDto> CreateImage(ImageDto imageDto);
        Task DeleteImage(int id);
    }
}
