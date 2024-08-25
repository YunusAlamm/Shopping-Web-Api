using AutoMapper;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.CartProducts.Dto;
using Shopping_WebApi.Features.CartProducts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.CartProducts.QueryHandlers
{
    public class CartProductsQueryHandler(
        IGenericRepository<Cart_Product> _genericRepository,
        IMapper _mapper
        ) : IRequestHandler<CartProductsQuery, IEnumerable<CartProductDto>>
    {
        public async Task<IEnumerable<CartProductDto>> Handle(CartProductsQuery request, CancellationToken cancellationToken)
        {
            var cartproducts = _genericRepository.GetAllAsync();

            return  _mapper.Map<IEnumerable<CartProductDto>>(cartproducts);
        }
    }
}
