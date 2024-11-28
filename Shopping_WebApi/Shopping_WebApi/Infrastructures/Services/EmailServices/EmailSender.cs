using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using Shopping_WebApi.Core.Models;

namespace Shopping_WebApi.Infrastructures.Services.EmailServices
{

    public class EmailSender(
        EmailConfiguration emailConfig
        ) : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig = emailConfig;

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Your Name", _emailConfig.From));
            message.To.Add(new MailboxAddress("", email));
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder { HtmlBody = htmlMessage };
            message.Body = bodyBuilder.ToMessageBody();

            using var client = new SmtpClient();
            try
            {
                await client.ConnectAsync(_emailConfig.SmtpServer, _emailConfig.Port, true);
                await client.AuthenticateAsync(_emailConfig.Username, _emailConfig.Password);
                await client.SendAsync(message);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to send email", ex);
            }
            finally
            {
                await client.DisconnectAsync(true);
                client.Dispose();
            }
        }
    }





}