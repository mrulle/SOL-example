using System.Net.Mail;

namespace SOL_example
{
    public interface IEmailSMTPService
    {
        public SmtpClient SmtpClient { get; }
        public void SendEmail(string email);
    }
}