using FluentValidation;
using Shopping_WebApi.Features.Orders.Commands;


namespace Shopping_WebApi.Features.Orders.Validators
{
    public class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Order ID is required.");
        }
    }

}
