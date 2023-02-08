using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOL_example
{
    public abstract class EmailSMTPService : IEmailSMTPService
    {
        //SMTP client dependency injection
        IEmailConnection _connection;
        public EmailSMTPService( IEmailConnection mailConn) { 
            _connection= mailConn;
        }
        //configuration file/secrets file depedency inject to get host ip and port
        public SmtpClient SmtpClient { get => _connection.Connect("",25); }



        //Open for extension of diffrent ways to send the email

        public abstract void SendEmail(string email);
        
    }
}
