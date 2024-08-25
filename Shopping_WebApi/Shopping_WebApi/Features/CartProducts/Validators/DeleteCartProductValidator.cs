using FluentValidation;
using Shopping_WebApi.Features.CartProduct.Commands;

namespace Shopping_WebApi.Features.CartProducts.Validators
{
    public class DeleteCartProductValidator : AbstractValidator<DeleteCartProductCommand>
    {
        public DeleteCartProductValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id is required.");

           
        }
    }

}


