using FluentValidation;
using Shopping_WebApi.Features.Comments.Commands;

namespace Shopping_WebApi.Features.Comments.Validators
{
    public class UpdateCommentValidator : AbstractValidator<UpdateCommentCommand>
    {
        public UpdateCommentValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id is required.");
            RuleFor(x => x.Content)
                .NotEmpty()
                .WithMessage("Content is required.")
                .MaximumLength(500)
                .WithMessage("Content cannot exceed 500 characters.");
            RuleFor(x => x.Rating)
                .InclusiveBetween(1, 5)
                .When(x => x.Rating.HasValue)
                .WithMessage("Rating must be between 1 and 5.");
            RuleFor(x => x.IsApproved)
                .NotNull()
                .WithMessage("IsApproved is required.");
        }
    }





}
