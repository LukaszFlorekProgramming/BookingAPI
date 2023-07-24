using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Commands.CreateHotel
{
    public class CreateHotelCommandValidator : AbstractValidator<CreateHotelCommand>
    {
        public CreateHotelCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(120)
                .Matches("^[a-zA-Z0-9 ]*$")
                .WithMessage("The Name field can only contain letters numbers and spaces.");

            RuleFor(x => x.City)
                .NotEmpty()
                .MaximumLength(60)
                .Matches("^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ0-9 ]*$")
                .WithMessage("The City field can only contain letters numbers and spaces including Polish characters.");

            RuleFor(x => x.Country)
                .NotEmpty()
                .MaximumLength(60)
                .Matches("^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ0-9 ]*$")
                .WithMessage("The Country field can only contain letters numbers and spaces including Polish characters.");
        }
    }
}
