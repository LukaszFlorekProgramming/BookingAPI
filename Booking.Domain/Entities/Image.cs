﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public byte[] PhotoResource { get; set; }
        public int? RoomId { get; set; }
        public Room Room { get; set; }

    }
}
