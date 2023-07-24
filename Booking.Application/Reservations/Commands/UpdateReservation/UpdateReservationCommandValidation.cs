using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Commands.UpdateReservation
{
    public class UpdateReservationCommandValidation : AbstractValidator<UpdateReservationCommand>
    {
        public UpdateReservationCommandValidation()
        {
            RuleFor(x => x.RoomId)
                .NotNull();
            RuleFor(x => x.UserName)
                .NotNull();
            RuleFor(x => x.StartDate)
               .NotEmpty();
            RuleFor(x => x.EndDate)
               .NotEmpty();
        }
    }
}
