using FluentValidation;

namespace Shopping_WebApi.Features.OrderProducts.Commands
{
    public class UpdateOrderProductCommandValidator : AbstractValidator<UpdateOrderProductCommand>
    {
        public UpdateOrderProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.");

            RuleFor(x => x.QuantityOfProduct)
                .GreaterThan(0).WithMessage("QuantityOfProduct must be greater than zero.");
        }
    }
}
