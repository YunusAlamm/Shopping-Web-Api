using MediatR;
using Shopping_WebApi.Features.SendEmail.Commands;
using Shopping_WebApi.Infrastructures.EmailServices;

namespace Shopping_WebApi.Features.SendEmail.CommandHandlers
{
    public class SendEmailCommandHandler(
        IEmailService _service
        ) : IRequestHandler<SendEmailCommand, bool>
    {
        public async Task<bool> Handle(SendEmailCommand request, CancellationToken cancellationToken)
        {
            
            
            await _service.SendEmailAsync(request.ToName, request.Subject, request.Body, request.ToEmail);

            return true;
        }
    }
}
