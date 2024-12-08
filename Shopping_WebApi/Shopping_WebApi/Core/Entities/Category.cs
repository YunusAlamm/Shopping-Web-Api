using System.ComponentModel.DataAnnotations;

namespace Shopping_WebApi.Core.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
