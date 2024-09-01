using MediatR;

namespace Shopping_WebApi.Features.Comments.Commands
{
    public class DeleteCommentCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }



}
