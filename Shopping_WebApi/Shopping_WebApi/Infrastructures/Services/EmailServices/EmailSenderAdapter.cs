
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI.Services;
using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Infrastructures.Services.EmailServices
    {
        public class EmailSenderAdapter : IEmailSender<User>
        {
            private readonly IEmailSender _emailSender;

            public EmailSenderAdapter(IEmailSender emailSender)
            {
                _emailSender = emailSender;
            }

        public Task SendConfirmationLinkAsync(User user, string email, string confirmationLink)
        {
            throw new NotImplementedException();
        }

        public Task SendEmailAsync(User user, string subject, string message)
            {
                // Assuming User.Email is properly set
                return _emailSender.SendEmailAsync(user.Email, subject, message);
            }

        public Task SendPasswordResetCodeAsync(User user, string email, string resetCode)
        {
            throw new NotImplementedException();
        }

        public Task SendPasswordResetLinkAsync(User user, string email, string resetLink)
        {
            throw new NotImplementedException();
        }
    }
    }


