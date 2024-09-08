using FluentValidation;
using MediatR;
using Shopping_WebApi.Features.Comments.Commands;
using Shopping_WebApi.Infrastructures.Repositories;

namespace Shopping_WebApi.Features.Comments.CommandHandlers
{
    public class UpdateCommentCommandHandler(
        ICommentRepository _commentRepository,
        IValidator<UpdateCommentCommand> _validator
        ) : IRequestHandler<UpdateCommentCommand, bool>
    {
        public async Task<bool> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var comment = await _commentRepository.GetByIdAsync(request.Id);

            comment.Content = request.Content;
            comment.UpdatedAt = DateTime.UtcNow;
            comment.IsApproved = request.IsApproved;
            comment.Rating = request.Rating;

            await _commentRepository.UpdateAsync(comment);
            return true;



        }
    }
}
