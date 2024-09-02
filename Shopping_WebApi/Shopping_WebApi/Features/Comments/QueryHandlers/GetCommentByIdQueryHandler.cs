using AutoMapper;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Comments.Dto;
using Shopping_WebApi.Features.Comments.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Comments.QueryHandlers
{
    public class GetCommentByIdQueryHandler(
        IGenericRepository<Comment> _genericRepository,
        IMapper _mapper
        ) : IRequestHandler<GetCommentByIdQuery, CommentDto>
    {
       

        public async Task<CommentDto> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {

            var comment =await _genericRepository.GetByIdAsync(request.Id);

            return _mapper.Map<CommentDto>( comment );
        }
    }
}
