using MediatR;

namespace Shopping_WebApi.Features.SendEmail.Commands
{
    public class SendEmailCommand: IRequest<bool>
    {
        public string ToName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public string ToEmail {  get; set; }
    }
}
