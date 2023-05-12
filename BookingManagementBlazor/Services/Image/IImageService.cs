using BookingManagementBlazor.Models.Image;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementBlazor.Services.Image
{
    public interface IImageService
    {
        Task<ImageVm> GetImages();
        Task<ImageDto> CreateImage(ImageDto imageDto);
        Task DeleteImage(int imageId);
    }
}
