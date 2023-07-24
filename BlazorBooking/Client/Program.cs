using BlazorBooking.Client;
using BlazorBooking.Client.Services.Hotel;
using BlazorBooking.Client.Services.Image;
using BlazorBooking.Client.Services.Reservation;
using BlazorBooking.Client.Services.Room;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("BlazorBooking.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
builder.Services.AddSingleton<ReservationService>();
builder.Services.AddHttpClient<IReservationService, ReservationService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44318/");
});
builder.Services.AddSingleton<RoomService>();
builder.Services.AddHttpClient<IRoomService, RoomService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44318/");
});
builder.Services.AddHttpClient<IImageService, ImageService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44318/");
});
builder.Services.AddHttpClient<IHotelService, HotelService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44318/");
});

builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazorBooking.ServerAPI"));
builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
