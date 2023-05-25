using AutoMapper;
using Booking.Application.Mappings;
using Booking.Application.Reservations.Queries.GetReservationDetail;
using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Queries.GetReservations
{
    public class ReservationsVm
    {
        public ICollection<ReservationDto> Reservations { get; set; }
        
    }
}
