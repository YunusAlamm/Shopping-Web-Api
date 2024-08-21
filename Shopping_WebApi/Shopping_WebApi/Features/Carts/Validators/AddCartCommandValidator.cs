using FluentValidation;
using Shopping_WebApi.Features.Carts.Commands;

public class AddCartCommandValidator : AbstractValidator<AddCartCommand>
{
    public AddCartCommandValidator()
    {
        RuleFor(x => x.CustomerId)
            .NotEmpty()
            .WithMessage("CustomerId is required.");

        RuleFor(x => x.Customer)
            .NotNull()
            .WithMessage("Customer information is required.");

        RuleFor(x => x.Products)
            .NotEmpty()
            .WithMessage("At least one product is required.")
            .Must(products => products != null && products.Count > 0)
            .WithMessage("Products collection cannot be empty.");

        RuleFor(x => x.TotalAmount)
            .GreaterThan(0)
            .WithMessage("Total amount must be greater than zero.");
    }
}
