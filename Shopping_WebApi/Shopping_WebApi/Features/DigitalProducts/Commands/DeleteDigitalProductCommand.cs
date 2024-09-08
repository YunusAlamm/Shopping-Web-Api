using MediatR;
namespace Shopping_WebApi.Features.DigitalProducts.Commands
{
    public class DigitalProductQueryCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
