using MediatR;
using Shopping_WebApi.Features.Comments.Dto;

namespace Shopping_WebApi.Features.Comments.Queries
{
    public class GetCommentsByProductIdQuery : IRequest<IEnumerable<CommentDto>>
    {
        public Guid ProductId { get; set; }
    }


}
