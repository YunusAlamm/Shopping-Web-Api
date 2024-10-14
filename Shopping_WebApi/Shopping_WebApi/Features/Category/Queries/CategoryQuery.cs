using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.Categories.Dto;

namespace Shopping_WebApi.Features.Categories.Queries
{
    public class CategoryQuery : IRequest<CategoryDto>
    {
        [FromQuery]
        public Guid Id { get; set; }
    }
}
