using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginSystem.Utils
{
    public class EnumValidator
    {

        public static bool IsEnumValueValid<TEnum>(int value) where TEnum : struct
        {
            // Verifica se o valor fornecido pertence ao enum
            return Enum.IsDefined(typeof(TEnum), value);
        }
    }
}