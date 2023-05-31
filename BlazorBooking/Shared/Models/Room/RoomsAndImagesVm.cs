using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBooking.Shared.Models.Room
{
    public class RoomsAndImagesVm
    {
        public ICollection<RoomAndImageDto> RoomsAndImages { get; set; }
    }
}
