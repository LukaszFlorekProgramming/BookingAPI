using BlazorBooking.Shared.Models.Image;
using System.Net.Http.Json;

namespace BlazorBooking.Client.Services.Image
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

        public async Task DeleteImage(int id)
        {
            var response = await _httpClient.DeleteAsync($"/api/images/{id}");
        }


        public async Task<ImagesVm> GetImages()
        {
            return await _httpClient.GetFromJsonAsync<ImagesVm>("api/images/GetImages");
        }
    }
}
