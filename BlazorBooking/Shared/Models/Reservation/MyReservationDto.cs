﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBooking.Shared.Models.Reservation
{
    public class MyReservationDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserName { get; set; }
        public string NameRoom { get; set; }
        public int? RoomId { get; set; }
    }
}
