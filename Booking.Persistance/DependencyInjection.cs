using Booking.Application.Interfaces;
using Booking.Persistance;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services)
        {
            services.AddScoped<IReservationDbContext, ReservationDbContext>();
            return services;
        }
    }
}
