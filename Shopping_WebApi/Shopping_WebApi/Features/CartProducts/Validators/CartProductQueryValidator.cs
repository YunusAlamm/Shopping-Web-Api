using FluentValidation;
using Shopping_WebApi.Features.CartProducts.Queries;

namespace Shopping_WebApi.Features.CartProducts.Validators
{
    public class CartProductQueryValidator: AbstractValidator<CartProductQuery>
    {
        public CartProductQueryValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id is required.");
        }

    }

}


