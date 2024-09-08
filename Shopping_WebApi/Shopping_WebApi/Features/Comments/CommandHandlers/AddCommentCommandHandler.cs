using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Comments.Commands;
using Shopping_WebApi.Infrastructures.Repositories;

namespace Shopping_WebApi.Features.Comments.CommandHandlers
{
    public class AddCommentCommandHandler(
        ICommentRepository _commentRepository,
        IValidator<AddCommentCommand> _validator
        ) : IRequestHandler<AddCommentCommand, string>
    {
        public async Task<string> Handle(AddCommentCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid) 
            {
                throw new ValidationException(validationResult.Errors);
            }

            var comment = new Comment
            {
                Content = request.Content,
                CreatedAt = request.CreatedAt,
                ProductId = request.ProductId,
                UserId = request.UserId

            };
            await _commentRepository.InsertAsync(comment);
            return "Tnx for your comment!";
        }
    }
}
