using FluentValidation;
using Shopping_WebApi.Features.Carts.Commands;

public class UpdateCartCommandValidator : AbstractValidator<UpdateCartCommand>
{
    public UpdateCartCommandValidator()
    {
        RuleFor(x => x.Products)
            .NotEmpty()
            .WithMessage("At least one product is required.")
            .Must(products => products != null && products.Count > 0)
            .WithMessage("Products collection cannot be empty.");

    }

}
