using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace TravelApp.Models.Validators
{
    public class TravelValidator : AbstractValidator<Travel>
    {
        public TravelValidator()
        {
            RuleFor(x => x.OriginId).NotNull().NotEmpty().WithMessage("Origin cannot be left blank.");
            RuleFor(x => x.DestinationId).NotNull().NotEmpty().WithMessage("Destination cannot be left blank.");
            RuleFor(x => x.DepartureDate).NotNull().NotEmpty().WithMessage("Departure Date cannot be left blank.");
        }
    }
}
