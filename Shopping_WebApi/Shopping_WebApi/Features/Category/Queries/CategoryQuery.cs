using MediatR;
using Shopping_WebApi.Features.Categories.Dto;

namespace Shopping_WebApi.Features.Categories.Queries
{
    public class CategoryQuery : IRequest<CategoryDto>
    {
        public Guid Id { get; set; }
    }
}
