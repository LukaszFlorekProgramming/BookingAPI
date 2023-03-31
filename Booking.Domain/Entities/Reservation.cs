﻿using Booking.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Persistance.Entities
{
    public class Reservation : AuditableEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? RoomId { get; set; }
        public Room Room { get; set; }
    }
}