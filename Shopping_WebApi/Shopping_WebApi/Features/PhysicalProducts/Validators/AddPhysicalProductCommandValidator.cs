using FluentValidation;
using Shopping_WebApi.Features.PhysicalProducts.Commands;

namespace Shopping_WebApi.Features.PhysicalProducts.Validators
{
    public class AddPhysicalProductCommandValidator: AbstractValidator<AddPhysicalProductCommand>
    {
        public AddPhysicalProductCommandValidator() 
        {


            RuleFor(x => x.Name)
                    .NotEmpty()
                    .WithMessage("Name is required.");
            RuleFor(x => x.Image)
                .NotEmpty()
                .WithMessage("Image is required.");
            RuleFor(x => x.Category)
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
