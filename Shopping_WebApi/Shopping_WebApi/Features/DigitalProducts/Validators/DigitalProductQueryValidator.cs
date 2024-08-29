using FluentValidation;
using Shopping_WebApi.Features.DigitalProducts.Commands;

namespace Shopping_WebApi.Features.DigitalProducts.Validators
{
    public class DigitalProductQueryValidator : AbstractValidator<DeleteDigitalProductCommand>
    {
        public DigitalProductQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required.");
        }
    }


}
