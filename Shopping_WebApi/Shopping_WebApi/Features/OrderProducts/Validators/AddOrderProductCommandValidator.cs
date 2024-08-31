using FluentValidation;

namespace Shopping_WebApi.Features.OrderProducts.Commands
{
    public class AddOrderProductCommandValidator : AbstractValidator<AddOrderProductCommand>
    {
        public AddOrderProductCommandValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty().WithMessage("OrderId is required.");

            RuleFor(x => x.Order)
                .NotNull().WithMessage("Order is required.");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("ProductId is required.");

            RuleFor(x => x.Product)
                .NotNull().WithMessage("Product is required.");

            RuleFor(x => x.QuantityOfProduct)
                .GreaterThan(0).WithMessage("QuantityOfProduct must be greater than zero.");
        }
    }
}
