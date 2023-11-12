using System;
using System.Globalization;

namespace LoginSystem.Utils
{
    public class DateValidator
    {
        public bool IsValidDate(string inputDate, string expectedFormat)
        {
            if (string.IsNullOrWhiteSpace(inputDate))
                return false;

            // Tenta fazer o parse da data no formato específico
            if (DateTime.TryParseExact(inputDate, expectedFormat, null, DateTimeStyles.None, out _))
            {
                return true; // Data válida
            }

            return false; // Data inválida
        }
    }
}