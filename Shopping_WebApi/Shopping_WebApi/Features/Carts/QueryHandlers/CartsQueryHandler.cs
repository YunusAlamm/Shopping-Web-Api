using AutoMapper;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Carts.Dtos;
using Shopping_WebApi.Features.Carts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Carts.QueryHandlers
{
    public class CartsQueryHandler(
        IGenericRepository<Cart> _genericRepository,
        IMapper _mapper
        )
        : IRequestHandler<CartsQuery, IEnumerable<CartDto>>
    {
        public async Task<IEnumerable<CartDto>> Handle(CartsQuery request, CancellationToken cancellationToken)
        {
            var carts = _genericRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<CartDto>>(carts);


        }
    }



}
