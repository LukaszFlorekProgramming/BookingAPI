using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Rooms.Commands.UpdateRoom
{
    public class UpdateRoomCommandValidator : AbstractValidator<UpdateRoomCommand>
    {
        public UpdateRoomCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(120)
                .Matches("^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ0-9 ]*$")
                .WithMessage("The Name field can only contain letters numbers and spaces including Polish characters.");

            RuleFor(x => x.Capacity)
                .InclusiveBetween(0, 16)
                .WithMessage("The Capacity field must be between 0 and 16.");

            RuleFor(x => x.IsBooked)
            .Must(x => x == true || x == false)
            .WithMessage("The IsBooked field can only accept true or false values.");

            RuleFor(x => x.PricePerNight)
                .InclusiveBetween(0, 100000)
                .WithMessage("The PricePerNight field must be between 0 and 100000.");

            RuleFor(x => x.Street)
               .NotEmpty()
               .MaximumLength(120)
               .Matches("^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ0-9 ]*$")
               .WithMessage("The Street field can only contain letters numbers and spaces including Polish characters.");

            RuleFor(x => x.BuildingNumber)
                .InclusiveBetween(0, 1000)
                .WithMessage("The BuildingNumber field must be between 0 and 1000.");

            RuleFor(x => x.RoomNumber)
               .InclusiveBetween(0, 1000)
               .WithMessage("The RoomNumber field must be between 0 and 1000.");

            RuleFor(x => x.PostalCode)
            .NotEmpty()
            .Matches(@"^[0-9-]*$")
            .WithMessage("The PostalCode field can only contain numbers and '-' (hyphen).");

            RuleFor(x => x.Street)
               .NotEmpty()
               .MaximumLength(120)
               .Matches("^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ0-9 ]*$")
               .WithMessage("The Street field can only contain letters numbers and spaces including Polish characters.");

            RuleFor(x => x.Country)
               .NotEmpty()
               .MaximumLength(120)
               .Matches("^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ0-9 ]*$")
               .WithMessage("The Country field can only contain letters numbers and spaces including Polish characters.");
        }
    }
}
