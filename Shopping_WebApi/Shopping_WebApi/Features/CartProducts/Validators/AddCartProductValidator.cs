using FluentValidation;
using Shopping_WebApi.Features.CartProduct.Commands;

namespace Shopping_WebApi.Features.CartProducts.Validators
{


    public class AddCartProductValidator : AbstractValidator<AddCartProductCommand>
    {
        public AddCartProductValidator()
        {
            RuleFor(x => x.CartId)
                .NotEmpty().NotNull().WithMessage("CartId is required.");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("ProductId is required.");

            RuleFor(x => x.Quantity)
                .GreaterThan(0).NotNull().WithMessage("Quantity must be greater than zero.");
        }
    }

}


