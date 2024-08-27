using MediatR;
using Shopping_WebApi.Features.Categories.Dto;

namespace Shopping_WebApi.Features.Categories.Queries
{
    public class CategoriesQuery : IRequest<IEnumerable<CategoryDto>> {}
}
