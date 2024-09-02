using AutoMapper;
using MediatR;
using Shopping_WebApi.Features.Comments.Dto;
using Shopping_WebApi.Features.Comments.Queries;
using Shopping_WebApi.Infrastructures.Repositories;

namespace Shopping_WebApi.Features.Comments.QueryHandlers
{
    public class GetCommentsByProductIdQueryHandler(
        CommentRepository _commentRepository,
        IMapper _mapper
        ) : IRequestHandler<GetCommentsByProductIdQuery, IEnumerable<CommentDto>>
    {
        public async Task<IEnumerable<CommentDto>> Handle(GetCommentsByProductIdQuery request, CancellationToken cancellationToken)
        {
            var comments = await _commentRepository.GetCommentsByProductIdAsync(request.ProductId);

            return _mapper.Map<IEnumerable<CommentDto>>(comments);
        }
    }
}
