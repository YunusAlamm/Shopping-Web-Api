using AutoMapper;
using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.OrderProducts.Dto;
using Shopping_WebApi.Features.OrderProducts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.OrderProducts.QueryHandlers
{
    public class OrderProductQueryHandler(
        IGenericRepository<OrderProduct> _genericRepository,
        IMapper _mapper,
        IValidator<OrderProductQuery> _validator
        ) : IRequestHandler<OrderProductQuery, OrderProductDto>
    {
        public async Task<OrderProductDto> Handle(OrderProductQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync( request, cancellationToken );
            if (!validationResult.IsValid) 
            {
                throw new ValidationException(validationResult.Errors);
            }

            var orderProduct = await _genericRepository.GetByIdAsync(request.Id);

            if (orderProduct == null)
            {
                throw new ArgumentNullException("OrderProduct not found");
            }


            return _mapper.Map<OrderProductDto>(orderProduct);
        }
    }
}
