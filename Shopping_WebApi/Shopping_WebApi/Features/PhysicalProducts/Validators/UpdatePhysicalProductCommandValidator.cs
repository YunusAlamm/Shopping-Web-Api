using FluentValidation;
using Shopping_WebApi.Features.PhysicalProducts.Commands;

namespace Shopping_WebApi.Features.PhysicalProducts.Validators
{
    public class UpdatePhysicalProductCommandValidator : AbstractValidator<UpdatePhysicalProductCommand> 
    {
        public UpdatePhysicalProductCommandValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("choose one item to update");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required.");

            RuleFor(x => x.Image)
                .NotEmpty()
                .WithMessage("Image is required.");

            RuleFor(x => x.Categories)
                .NotNull()
                .WithMessage("Category is required.");

            RuleFor(x => x.Price)
                .GreaterThan(0)
                .WithMessage("Price must be greater than zero.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description is required.");

            RuleFor(x => x.Weight)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.Dimensions)
                .NotEmpty();

            RuleFor(x => x.IsReturnable)
                .NotNull();
        }
    }
}
