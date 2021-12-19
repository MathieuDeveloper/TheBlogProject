using System;
using System.Threading.Tasks;

namespace TheBlogProject.Services
{
    public class EmailService : IBlogEmailSender
    {
        public Task SendContactEmailAsync(string emailFrom, string name, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}
