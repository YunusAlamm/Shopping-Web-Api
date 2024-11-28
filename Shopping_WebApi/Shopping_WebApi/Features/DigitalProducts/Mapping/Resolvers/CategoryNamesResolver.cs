using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Dto;
using Shopping_WebApi.Infrastructure.Repositories;


namespace Shopping_WebApi.Features.DigitalProducts.Mapping.Resolvers
{

    public class CategoryNamesResolver(
        IGenericRepository<Core.Entities.Category> _categoryRepository
        ) : IValueResolver<DigitalProduct, DigitalProductDto, List<string>>
    {
        public List<string> Resolve(DigitalProduct source, DigitalProductDto destination, List<string> destMember, ResolutionContext context)
        {

            var categoryIds = source.CategoryIds;
            var categories = _categoryRepository.GetAllByConditionsAsync(c => categoryIds.Contains(c.Id)).Result;
            return categories.Select(c => c.Name).ToList();
        }
    }

}
