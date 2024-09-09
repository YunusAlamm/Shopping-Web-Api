using MediatR;
namespace Shopping_WebApi.Features.DigitalProducts.Commands
{
    public class DeleteDigitalProductCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
