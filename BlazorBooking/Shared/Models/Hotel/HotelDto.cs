using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBooking.Shared.Models.Hotel
{
    public class HotelDto
    {
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; }
        public string Country { get; set; }
    }
}
