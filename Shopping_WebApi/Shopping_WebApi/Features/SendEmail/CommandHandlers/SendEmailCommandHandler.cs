//using MediatR;
//using Microsoft.AspNetCore.Identity.UI.Services;
//using Shopping_WebApi.Features.SendEmail.Commands;

//namespace Shopping_WebApi.Features.SendEmail.CommandHandlers
//{
//    public class SendEmailCommandHandler(
//        IEmailSender _emailSender
//        ) : IRequestHandler<SendEmailCommand, bool>
//    {
//        public async Task<bool> Handle(SendEmailCommand request, CancellationToken cancellationToken)
//        {
//            await _emailSender.SendEmailAsync(request.ToEmail, request.Subject, request.Body);
//            return true;
//        }
//    }
//}
