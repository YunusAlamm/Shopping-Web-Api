using AutoMapper;
using MediatR;
using Shopping_WebApi.Features.Comments.Dto;
using Shopping_WebApi.Features.Comments.Queries;
using Shopping_WebApi.Infrastructures.Repositories;

namespace Shopping_WebApi.Features.Comments.QueryHandlers
{
    public class GetCommentsByUserIdQueryHandler(
        CommentRepository _commentRepository,
        IMapper _mapper
        ) : IRequestHandler<GetCommentsByUserIdQuery, IEnumerable<CommentDto>>
    {
        public async Task<IEnumerable<CommentDto>> Handle(GetCommentsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var comments = await _commentRepository.GetCommentsByUserIdAsync(request.UserId);
            return _mapper.Map<IEnumerable<CommentDto>>(comments );
        }
    }
}
