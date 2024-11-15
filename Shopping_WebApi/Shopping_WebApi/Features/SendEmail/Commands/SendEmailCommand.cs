using MediatR;

namespace Shopping_WebApi.Features.SendEmail.Commands
{
    public class SendEmailCommand : IRequest<bool>
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; } 
    }
}
