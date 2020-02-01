using GentlePay.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GentlePay.Domain.Tests.UserUnitTests
{
    [TestFixture]
    public class AddFundsToAccount_Should
    {
        [Test]
        public void AddAmount_AsExpected()
        {
            //Arrange
            var user = new User("FirstName", "LastName");
            var account = new Account(user, "CHF");
            user.Accounts.Add(account);

            //Act
            user.AddFundsToAccount(account, 1000);

            //Assert
            Assert.AreEqual(1000, account.Balance);
        }

        [Test]
        public void ThrowException_When_AccountDoesNotCorrespondToUser()
        {
            //Arrange
            var user = new User("FirstName", "LastName");
            var account = new Account(user, "CHF");

            //Act & Assert
            Assert.Throws<ArgumentException>(() => user.AddFundsToAccount(account, 1000));
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void ThrowException_When_AmountToAdd_IsLessOrEqualToZero(decimal amountToAdd)
        {
            //Arrange
            var user = new User("FirstName", "LastName");
            var account = new Account(user, "CHF");

            //Act & Assert
            Assert.Throws<ArgumentException>(() => user.AddFundsToAccount(account, amountToAdd));
        }
    }
}
