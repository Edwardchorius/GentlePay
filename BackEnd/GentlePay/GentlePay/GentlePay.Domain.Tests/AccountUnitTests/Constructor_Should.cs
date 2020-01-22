using GentlePay.Domain.Constants;
using GentlePay.Domain.Entities;
using GentlePay.Domain.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GentlePay.Domain.Tests.AccountUnitTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void Initialize_AccountInstance_When_PassedValidArguments()
        {
            //Arrange
            User holder = new User("firstName", "lastName");
            string accountCurrency = "CHF";


            //Act
            Account account = new Account(holder, accountCurrency);

            //Assert
            Assert.IsNotNull(account);
            Assert.IsInstanceOf(typeof(Account), account);
            Assert.AreEqual(holder, account.Holder);
            Assert.AreEqual(StringToEnum.StringValueToCurrencyEnumValue[accountCurrency], account.Currency);
            Assert.IsTrue(account.Balance == 0);
            Assert.IsNotNull(account.IBAN);
            Assert.IsNotEmpty(account.IBAN);
            Assert.IsFalse(account.IsDeleted);
        }

        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        public void Throw_ArgumentException_When_Currency_IsNullOrWhiteSpace(string inputValueForCurrency)
        {
            //Arrange
            User holder = new User("firstName", "lastName");
            Account account;

            //Act && Assert
            Assert.Throws<ArgumentException>(() => account = new Account(holder, inputValueForCurrency));
        }

        [Test]
        public void Throw_ArgumentException_When_Currency_IsNotAvailable()
        {
            //Arrange
            User holder = new User("firstName", "lastName");
            Account account;
            string invalidCurrency = "NoSuchCurrency";

            //Act && Assert
            Assert.Throws<ArgumentException>(() => account = new Account(holder, invalidCurrency));
        }
    }
}
