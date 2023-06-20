using Booking.Application;
using Booking.Infrastructure;
using Booking.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddDbContext<ReservationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});

// Add services to the container.

builder.Services.AddApplication();
builder.Services.AddPersistance();
builder.Services.AddInfrastructure();
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("https://localhost:7096")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { 
        Title = "BookingApplication",
        Version = "v1",
        Description = "This is an application for information exchange in our Booking project.",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "£ukasz",
            Email = "lukaszflorek2@gmail.com",
            Url = new Uri ("https://github.com/LukaszFlorekProgramming/BookingAPI")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();
app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
