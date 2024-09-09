using FluentValidation;
using MediatR;
using Shopping_WebApi.Features.Comments.Commands;
using Shopping_WebApi.Infrastructures.Repositories;

namespace Shopping_WebApi.Features.Comments.CommandHandlers
{
    public class DeleteCommentCommandHandler(
        ICommentRepository _commentRepository,
        IValidator<DeleteCommentCommand> _validator
        ) : IRequestHandler<DeleteCommentCommand, bool>
    {
        public async Task<bool> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid) 
            {
                throw new ValidationException(validationResult.Errors);
            }

            var comment = await _commentRepository.GetByIdAsync(request.Id);
            comment.IsDeleted = true;
            await _commentRepository.UpdateAsync(comment);
            return true;
        }
    }
}
