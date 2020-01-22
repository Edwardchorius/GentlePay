using GentlePay.Domain.Constants;
using GentlePay.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GentlePay.Domain.Entities
{
    public class Account
    {
        public Account(User holder, string currency)
        {
            this.Holder = holder ?? throw new ArgumentException();

            if (string.IsNullOrWhiteSpace(currency))
            {
                throw new ArgumentException();
            }

            if (!StringToEnum.StringValueToCurrencyEnumValue.ContainsKey(currency))
            {
                throw new ArgumentException();
            }

            this.Currency = StringToEnum.StringValueToCurrencyEnumValue[currency];

            this.IBAN = Guid.NewGuid().ToString();
            this.Balance = 0m;
        }

        public User Holder { get; set; }
        public Currency? Currency { get; set; }
        public string IBAN { get; set; }
        public decimal Balance { get; set; }
        public bool IsDeleted { get; set; }
    }
}
