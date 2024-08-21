using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Carts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Carts.CommandHandlers
{
    public class DeleteCartCommandHandler(IGenericRepository<Cart> _genericRepository,IValidator<DeleteCartCommand> _validator): IRequestHandler<DeleteCartCommand, bool>
    {
        public  async Task<bool> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
        {
            var validationResult  = await _validator.ValidateAsync(request,cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            await _genericRepository.DeleteAsync(request.Id);
            return true;
        }
    }
}
