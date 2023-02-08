using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL_example
{
    public class LoginApplication
    {
        //Liskov, brug af interfaces
        IEmailSMTPService _emailService;
        IValidation _validation;
        public LoginApplication(IValidation validation, IEmailSMTPService emailService)
        {
            _validation = validation;
            _emailService = emailService;
        }

        public bool Login(string username, string password)
        {
            if (_validation.Validate(username, password)) {
                return true;
             }
            _emailService.SendEmail(username); //username is the email
            return false;
        }

    }
}
