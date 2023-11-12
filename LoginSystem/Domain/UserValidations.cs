using System;
using LoginSystem.Utils;
using LoginSystem.Models;

namespace LoginSystem.Domain
{
    public class UserValidations
    {
        private readonly RegexUtilities _regexutils = new RegexUtilities();
        private readonly DateValidator _date = new DateValidator();
        private readonly EnumValidator _enum = new EnumValidator();

        public bool ValidateName(string name)
        {
            string pattern = @"^[a-zA-Z'-]+$";

            return _regexutils.IsValidSting(name, pattern);
        }

        public bool ValidateBirthDate(string birthDate)
        {
            string expectedFormat  = "yyyy-MM-dd";

            return _date.IsValidDate(birthDate, expectedFormat);
        }

        public bool IsPositionExists(int position)
        {
            bool exists = EnumValidator.IsEnumValueValid<EnumRolePosition>(position);

            return exists;
        }
        
    }
}