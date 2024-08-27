using AutoMapper;
using MediatR;
using Shopping_WebApi.Features.Categories.Dto;
using Shopping_WebApi.Features.Categories.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Categories.QueryHandlers
{
    public class CategoriesQueryHandler(
        IGenericRepository<Core.Entities.Category> _genericRepository,
        IMapper _mapper
        ) : IRequestHandler<CategoriesQuery,IEnumerable<CategoryDto>>
    {
        

        public async Task<IEnumerable<CategoryDto>> Handle(CategoriesQuery request, CancellationToken cancellationToken)
        {

            var categories = await _genericRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }
    }
}
