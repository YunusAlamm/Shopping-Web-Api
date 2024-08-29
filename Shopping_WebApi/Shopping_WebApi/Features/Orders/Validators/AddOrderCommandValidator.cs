using FluentValidation;
using Shopping_WebApi.Features.Orders.Commands;


namespace Shopping_WebApi.Features.Orders.Validators
{

    public class AddOrderCommandValidator : AbstractValidator<AddOrderCommand>
    {
        public AddOrderCommandValidator()
        {
            RuleFor(x => x.TotalAmount)
                .GreaterThan(0)
                .WithMessage("Total amount must be greater than zero.");
            RuleFor(x => x.PurchaseTime)
                .NotEmpty()
                .WithMessage("Purchase time is required.");
            RuleFor(x => x.Products)
                .NotEmpty()
                .WithMessage("Products are required.");
            RuleFor(x => x.CustomerId)
                .NotEmpty()
                .WithMessage("Customer ID is required.");
        }
    }

}
