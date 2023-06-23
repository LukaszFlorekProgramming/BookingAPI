using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Queries.GetHotels
{
    public class HotelsVm
    {
        public ICollection<HotelDto> Hotels { get; set; }
    }
}
