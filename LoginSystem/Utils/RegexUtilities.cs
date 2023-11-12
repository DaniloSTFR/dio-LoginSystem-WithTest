using System;
using System.Text.RegularExpressions;

namespace LoginSystem.Utils
{
    public class RegexUtilities
    {
        public bool IsValidSting(string str_text, string pattern)
        {
            if (string.IsNullOrWhiteSpace(str_text))
                return false;

            try
            {
                // Verifica se o str_text corresponde ao padrão
                return Regex.IsMatch(str_text,
                    pattern,
                    RegexOptions.IgnoreCase);
            }
            catch (RegexParseException)
            {
                return false;
            }
        }
    }
}