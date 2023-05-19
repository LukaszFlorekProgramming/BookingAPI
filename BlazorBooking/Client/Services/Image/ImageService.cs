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

        public async Task<int> DeleteImage(int id)
        {
            return await _httpClient.DeleteFromJsonAsync<int>($"/api/images/{id}");
        }


        public async Task<ImageVm> GetImages()
        {
            return await _httpClient.GetFromJsonAsync<ImageVm>("api/images/GetImages");
        }
    }
}
