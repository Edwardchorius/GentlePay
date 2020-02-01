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

            //Act
            user.AddFundsToAccount(account, 1000);

            //Assert
            Assert.AreEqual(1000, account.Balance);
        }
    }
}
