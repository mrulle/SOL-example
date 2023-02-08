using System.Net.Mail;

namespace SOL_example
{
    public interface IEmailConnection
    {
        SmtpClient Connect(string host, int port);
    }
}