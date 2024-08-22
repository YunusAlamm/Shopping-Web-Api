using FluentValidation;
using Shopping_WebApi.Features.CartProduct.Commands;

public class UpdateCartProductCommandValidator : AbstractValidator<UpdateCartProductCommand>
{
    public UpdateCartProductCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.");

        RuleFor(x => x.Quantity)
            .GreaterThan(0).WithMessage("Quantity must be greater than zero.");
    }
}

