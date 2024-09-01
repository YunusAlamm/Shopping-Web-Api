using MediatR;
using Shopping_WebApi.Features.Comments.Dto;

namespace Shopping_WebApi.Features.Comments.Queries
{
    public class GetCommentByIdQuery: IRequest<CommentDto>
    {
        public Guid Id { get; set; }
    }


}
