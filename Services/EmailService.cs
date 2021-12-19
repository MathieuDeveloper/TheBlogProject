using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Threading.Tasks;
using TheBlogProject.ViewModels;

namespace TheBlogProject.Services
{
    public class EmailService : IBlogEmailSender
    {
        private readonly MailSettings _mailSettings;

        public EmailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public Task SendContactEmailAsync(string emailFrom, string name, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var email = new MimeMessage();
        }
    }
}
