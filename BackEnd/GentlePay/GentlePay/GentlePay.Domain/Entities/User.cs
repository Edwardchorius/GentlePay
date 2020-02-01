using System;
using System.Collections.Generic;
using System.Linq;
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
        public ICollection<Account> Accounts { get; set; }

        public void AddFundsToAccount(Account accountToAddTo, decimal amount)
        {
            var userAccountToAddTo = this.Accounts.FirstOrDefault(account => account.Equals(accountToAddTo));

            if (amount <= 0)
            {
                throw new ArgumentException($"{amount} should be larger than 0");
            }
            if(userAccountToAddTo is null)
            {
                throw new ArgumentException("No such account");
            }

            userAccountToAddTo.Balance += amount;
        }
    }
}
