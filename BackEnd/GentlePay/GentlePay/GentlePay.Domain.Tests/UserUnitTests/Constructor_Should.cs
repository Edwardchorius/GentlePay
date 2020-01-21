using GentlePay.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

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
        }
    }
}
