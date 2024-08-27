using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Features.Categories.Dto
{
    public class CategoryDto
    {
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
