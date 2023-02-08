using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace SOL_example
{
    public class EmailMessage : EmailSMTPService
    {
        public EmailMessage(IEmailConnection mailConn) : base(mailConn)
        {
        }

        public override void SendEmail(string email)
        {
            //base.SmtpClient call outs
            //Here I would handle the SMTP from base class
            //and write the Email type
            throw new NotImplementedException();
        }
    }
}
