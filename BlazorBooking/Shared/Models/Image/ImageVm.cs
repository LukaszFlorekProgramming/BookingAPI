using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBooking.Shared.Models.Image
{
    public class ImageVm
    {
        public ICollection<ImageDto> Images { get; set; }
    }
}
