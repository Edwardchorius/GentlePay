using System;
using System.Collections.Generic;
using System.Text;

namespace GentlePay.Domain.Entities
{
    public class User
    {
        public User(string firstName, string lastName)
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
    }
}
