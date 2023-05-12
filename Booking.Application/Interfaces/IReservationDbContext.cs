using Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Interfaces
{
    public interface IReservationDbContext
    {
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<Image> Images { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
    }
}
