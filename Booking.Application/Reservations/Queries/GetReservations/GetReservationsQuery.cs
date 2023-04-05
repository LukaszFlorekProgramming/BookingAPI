using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Queries.GetReservations
{
    public class GetReservationsQuery : IRequest<ReservationsVm>
    {
    }
}
