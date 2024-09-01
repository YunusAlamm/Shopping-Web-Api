using FluentValidation;
using Shopping_WebApi.Features.PhysicalProducts.Commands;

namespace Shopping_WebApi.Features.PhysicalProducts.Validators
{
    public class DeletePhysicalProductCommandValidator : AbstractValidator<DeletePhysicalProductCommand> 
    { 
        public DeletePhysicalProductCommandValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("choose one item to delete");

        } 
    }
}
