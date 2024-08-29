using FluentValidation;
using Shopping_WebApi.Features.Orders.Commands;


namespace Shopping_WebApi.Features.Orders.Validators
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Order ID is required.");
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
