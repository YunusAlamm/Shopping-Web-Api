using MediatR;
using Shopping_WebApi.Features.Comments.Dto;

namespace Shopping_WebApi.Features.Comments.Queries
{
    public class GetCommentsByUserIdQuery : IRequest<IEnumerable<CommentDto>>
    {
        public Guid UserId { get; set; }
    }


}
