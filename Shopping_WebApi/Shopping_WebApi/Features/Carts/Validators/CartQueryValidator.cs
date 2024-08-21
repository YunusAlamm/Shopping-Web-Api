using FluentValidation;
using Shopping_WebApi.Features.Carts.Queries;

namespace Shopping_WebApi.Features.Carts.Validators
{
    public class CartQueryValidator : AbstractValidator<CartQuery>
    {
        public CartQueryValidator()
        {

            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull();
        }
    }
}
