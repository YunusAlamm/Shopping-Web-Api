using FluentValidation;
using Shopping_WebApi.Features.PhysicalProducts.Queries;

namespace Shopping_WebApi.Features.PhysicalProducts.Validators
{
    public class PhysicalProductQueryValidator : AbstractValidator<PhysicalProductQuery> 
    {
        public PhysicalProductQueryValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id cannot be empty or invalid");
        }
    }
}
