using MediatR;
using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Features.Carts.Commands
{
    public class AddCartCommand: IRequest<bool>
    {
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Cart_Product> Products { get; set; }
        

    }
}
