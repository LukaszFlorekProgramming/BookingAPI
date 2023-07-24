using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Commands.CreateHotel
{
    public class CreateHotelCommandValidate : AbstractValidator<CreateHotelCommand>
    {
        public CreateHotelCommandValidate()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(250);

        }
    }
}
