using GentlePay.Domain.Entities;
using NUnit.Framework;
using System;

namespace GentlePay.Domain.Tests.UserUnitTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void Initialize_UserInstance_When_PassedValidArguments()
        {
            //Arrange
            string firstName = "firstName";
            string lastName = "lastName";

            //Act
            User newUser = new User(firstName, lastName);

            //Assert
            Assert.IsNotNull(newUser);
            Assert.IsInstanceOf(typeof(User), newUser);
            Assert.IsNotNull(newUser.FirstName);
            Assert.IsNotNull(newUser.LastName);
            Assert.IsNotNull(newUser.Accounts);
            Assert.AreEqual(newUser.FirstName, firstName);
            Assert.AreEqual(newUser.LastName, lastName);
        }

        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        public void Throw_ArgumentException_When_FirstName_IsNullOrWhiteSpace(string inputValueForFirstName)
        {
            //Arrange
            string lastName = "lastName";

            User newUser;

            //Act && Assert
            Assert.Throws<ArgumentException>(() => newUser = new User(inputValueForFirstName, lastName));
        }

        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        public void Throw_ArgumentException_When_LastName_IsNullOrWhiteSpace(string inputValueForLastName)
        {
            //Arrange
            string firstName = "lastName";

            User newUser;

            //Act && Assert
            Assert.Throws<ArgumentException>(() => newUser = new User(firstName, inputValueForLastName));
        }
    }
}
