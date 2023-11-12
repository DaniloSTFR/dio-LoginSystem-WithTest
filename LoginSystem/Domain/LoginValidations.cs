using System;
using LoginSystem.Utils;

namespace LoginSystem.Domain
{
    public class LoginValidations
    {

        private readonly RegexUtilities _regexutils = new RegexUtilities();

        public bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return _regexutils.IsValidSting(email, pattern);
        }

        public bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            return _regexutils.IsValidSting(password, pattern);
        }
        
    }
}