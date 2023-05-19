using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBooking.Shared.Models.Reservation
{
    public class ReservationsVm
    {
        public ICollection<ReservationDto> Reservations { get; set; }
    }
}
