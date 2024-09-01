using FluentValidation;
using Shopping_WebApi.Features.Comments.Commands;

namespace Shopping_WebApi.Features.Comments.Validators
{
    public class DeleteCommentCommandValidator : AbstractValidator<DeleteCommentCommand> 
    {
        public DeleteCommentCommandValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull();
        }
    }





}
