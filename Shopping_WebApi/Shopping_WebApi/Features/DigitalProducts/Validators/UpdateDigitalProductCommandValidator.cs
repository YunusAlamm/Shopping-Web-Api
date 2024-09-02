using FluentValidation;
using Shopping_WebApi.Features.DigitalProducts.Commands;

namespace Shopping_WebApi.Features.DigitalProducts.Validators
{
    public class UpdateDigitalProductCommandValidator : AbstractValidator<UpdateDigitalProductCommand>
    {
        public UpdateDigitalProductCommandValidator()
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

            RuleFor(x => x.DigitalFormat)
                .NotEmpty()
                .WithMessage("Digital format is required.");

            RuleFor(x => x.DownloadLink)
                .NotEmpty()
                .WithMessage("Download link is required.");
        }
    }


}
