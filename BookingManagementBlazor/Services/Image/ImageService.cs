using BookingManagementBlazor.Models.Image;
using BookingManagementBlazor.Models.Reservation;
using BookingManagementBlazor.Pages;
using BookingManagementBlazor.Services.Reservation;

namespace BookingManagementBlazor.Services.Image
{
    public class ImageService : IImageService
    {
        private readonly HttpClient _httpClient;
        public ImageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ImageDto> CreateImage(ImageDto imageDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/images", imageDto);
            return imageDto;
        }

        public async Task<int> DeleteImage(int id)
        {
            //var response = await _httpClient.DeleteFromJsonAsync<int>($"/api/images/{id}");
            return await _httpClient.DeleteFromJsonAsync<int>($"/api/images/{id}");
        }

        /*public async Task DeleteImage(ImageDto imageDto)
        {
            var response = await _httpClient.DeleteFromJsonAsync<int>($"/api/images/{imageDto.Id}");
        }*/

        public async Task<ImageVm> GetImages()
        {
            return await _httpClient.GetFromJsonAsync<ImageVm>("api/images/GetImages");
        }

    }
}
