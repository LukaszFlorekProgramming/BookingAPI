using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Queries.GetImages
{
    public class ImagesVm
    {
        public ICollection<ImageDto> Images { get; set; }
    }
}
