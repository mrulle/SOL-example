using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL_example
{
    //Single responability
    //denne klasse står kun for at validere
    public class Validation : IValidation
    {
        
        public Validation() {
        
        }
        public bool Validate(string username, string password)
        {
            if (!String.IsNullOrWhiteSpace(username) &&
                !String.IsNullOrWhiteSpace(password))
            {
                return true;
            }
            return false;
        }

        
    }
}
