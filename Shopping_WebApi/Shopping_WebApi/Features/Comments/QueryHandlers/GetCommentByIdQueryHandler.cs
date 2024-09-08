using AutoMapper;
using MediatR;
using Shopping_WebApi.Features.Comments.Dto;
using Shopping_WebApi.Features.Comments.Queries;
using Shopping_WebApi.Infrastructures.Repositories;

namespace Shopping_WebApi.Features.Comments.QueryHandlers
{
    public class GetCommentByIdQueryHandler(
        ICommentRepository _commentRepository,
        IMapper _mapper
        ) : IRequestHandler<GetCommentByIdQuery, CommentDto>
    {


        public async Task<CommentDto> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {

            var comment = await _commentRepository.GetByIdAsync(request.Id);

            return _mapper.Map<CommentDto>(comment);
        }
    }
}
