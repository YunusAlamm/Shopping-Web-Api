using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.TelegramFeatures.Commands;
using Shopping_WebApi.Infrastructures.TelegramService;

namespace Shopping_WebApi.Features.TelegramFeatures.CommandHandlers
{
    public class NewProductCommandHandler(
        ITelegramService _service
        ) : IRequestHandler<NewProductCommand, bool>
    {
        public async Task<bool> Handle(NewProductCommand request, CancellationToken cancellationToken)
        {
            var message = $"New Product: {request.Name}\nPrice: {request.Price}\nDescription: {request.Description}";
            await _service.SendMessage(message);
            return true;
            
        }
    }
}
