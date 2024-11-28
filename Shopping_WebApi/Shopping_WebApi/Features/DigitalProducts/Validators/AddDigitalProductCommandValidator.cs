using FluentValidation;
using Shopping_WebApi.Features.DigitalProducts.Commands;

namespace Shopping_WebApi.Features.DigitalProducts.Validators
{


    public class AddDigitalProductCommandValidator : AbstractValidator<AddDigitalProductCommand>
    {
        public AddDigitalProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required.");
            RuleFor(x => x.Image)
                .NotEmpty()
                .WithMessage("Image is required.");
            RuleFor(x => x.CategoryIds)
                .NotNull()
                .WithMessage("CategoryIds is required.");
            RuleFor(x => x.Price)
                .GreaterThan(0)
                .WithMessage("Price must be greater than zero.");
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description is required.");
            RuleFor(x => x.DigitalFormat)
                .NotEmpty()
                .WithMessage("Digital format is required.");
            RuleFor(x => x.DownloadLink)
                .NotEmpty()
                .WithMessage("Download link is required.");
        }
    }


}
