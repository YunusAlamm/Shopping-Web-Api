using Microsoft.AspNetCore.Identity.UI.Services;

namespace Shopping_WebApi.Infrastructures.EmailServices
{




    public class DummyEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {

            return Task.CompletedTask;
        }
    }
}