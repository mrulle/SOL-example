using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOL_example
{
    public class EmailConection : IEmailConnection
    {
        public EmailConection() { }

        public SmtpClient Connect(string host, int port)
        {
            throw new NotImplementedException();
        }
    }
}
