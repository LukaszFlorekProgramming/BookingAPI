using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Persistance.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public bool IsBooked { get; set; }
        public double PricePerNight { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int RoomNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public ICollection<Reservation> Reservations { get; set; } 
    }
}
