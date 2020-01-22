using GentlePay.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GentlePay.Domain.Constants
{
    public static class StringToEnum
    {
        public static Dictionary<string, Currency> StringValueToCurrencyEnumValue = new Dictionary<string, Currency>()
        {
            { "BGN", Currency.BGN },
            { "USD", Currency.USD },
            { "EUR", Currency.EUR },
            { "GBP", Currency.GBP },
            { "CHF", Currency.CHF }
        };
    }
}
