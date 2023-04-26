using BookingManagementBlazor.Models;
using BookingManagementBlazor.Services.Reservation;
using BookingManagementBlazor.Services.Room;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<ReservationService>();
builder.Services.AddHttpClient<IReservationService, ReservationService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7269/");
});
builder.Services.AddSingleton<RoomService>();
builder.Services.AddHttpClient<IRoomService, RoomService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7269/");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
