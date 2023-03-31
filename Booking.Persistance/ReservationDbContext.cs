using Booking.Domain.Common;
using Booking.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Persistance
{
    public class ReservationDbContext : DbContext
    {
        public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(d =>
            {
                d.HasData(new Room()
                {
                    Id = 1,
                    Name = "Room1",
                    Capacity = 10,
                    IsBooked = false
                });
            });

            modelBuilder.Entity<Reservation>(d =>
            {
                d.HasData(new Reservation()
                {
                    Id = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CreatedBy = string.Empty,
                    Created = DateTime.Now,
                    ModifiedBy = string.Empty,
                    Modified = DateTime.Now,
                    StatusId = 1,
                    InactivatedBy = string.Empty,
                    Inactivated = DateTime.Now
                });

            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken()) 
        {
            foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.Inactivated = DateTime.Now;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 1;
                        entry.State = EntityState.Modified;
                        break;
                    
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
