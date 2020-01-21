using System;
using System.Collections.Generic;
using System.Text;

namespace GentlePay.Domain.Entities
{
    public class User
    {
        public User(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException(firstName);
            }

            this.FirstName = firstName;

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException(lastName);
            }

            this.LastName = lastName;

            this.Accounts = new List<Account>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
    }
}
