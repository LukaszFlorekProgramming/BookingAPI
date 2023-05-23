using Booking.Application.Reservations.Queries.GetReservationDetail;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Queries.GetImageDetail
{
    public class GetImageDetailQuery : IRequest<ImageDetailVm>
    {
        public int Id { get; set; }
    }
}
