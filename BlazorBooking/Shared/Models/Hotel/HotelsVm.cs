using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBooking.Shared.Models.Hotel
{
    public class HotelsVm
    {
        public ICollection<HotelDto> Hotels { get; set; }
    }
}
