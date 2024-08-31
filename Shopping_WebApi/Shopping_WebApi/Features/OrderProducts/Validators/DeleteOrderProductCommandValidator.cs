using FluentValidation;

namespace Shopping_WebApi.Features.OrderProducts.Commands
{
    public class DeleteOrderProductCommandValidator : AbstractValidator<DeleteOrderProductCommand>
    {
        public DeleteOrderProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.");
        }
    }
}
