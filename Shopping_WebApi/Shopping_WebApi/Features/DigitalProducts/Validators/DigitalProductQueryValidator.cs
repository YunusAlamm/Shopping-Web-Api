using FluentValidation;
using Shopping_WebApi.Features.DigitalProducts.Queries;

namespace Shopping_WebApi.Features.DigitalProducts.Validators
{
    public class DigitalProductQueryValidator : AbstractValidator<DigitalProductQuery>
    {
        public DigitalProductQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required.");
        }
    }


}
