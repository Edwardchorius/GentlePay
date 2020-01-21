using GentlePay.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GentlePay.Domain.Entities
{
    public class Account
    {
        public Account()
        {

        }

        public User Holder { get; set; }
        public Currency Currency { get; set; }
        public string IBAN { get; set; }
        public decimal Balance { get; set; }
        public bool IsDeleted { get; set; }
    }
}
