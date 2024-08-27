using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Categories.Dto;

namespace Shopping_WebApi.Features.Categories.Mapping
{
    public class CategoryMapping: Profile
    {
        public CategoryMapping() 
        {
            CreateMap<Core.Entities.Category, CategoryDto>();
            CreateMap<CategoryDto, Core.Entities.Category>();
        }
    }
}
