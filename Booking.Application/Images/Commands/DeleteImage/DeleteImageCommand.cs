using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Commands.DeleteImage
{
    public class DeleteImageCommand : IRequest
    {
        public int Id { get; set; }
    }
}
