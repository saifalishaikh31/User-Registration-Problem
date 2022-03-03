using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProgram;

namespace UserRegistrationProblemTesting
{
    [TestClass]
    public class UserRegistrationTest
    {
        [TestMethod]
        [DataRow("Saif", "Saif")]
        [DataRow("sa", "Enter Valid First Name")]
        public void TestMoodForFirstName(string userInput, string expected)
        {
            Validations validations = new Validations();
            string actual = validations.ValidateFirstName(userInput);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Shaikh", "Shaikh")]
        [DataRow("sh", "Enter Valid Last Name")]
        public void TestMoodForLastName(string userInput, string expected)
        {
            Validations validations = new Validations();
            string actual = validations.ValidateLastName(userInput);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Saif@gmail.com", "Saif@gmail.com")]
        [DataRow("s@gmail", "Enter Valid Email")]
        public void TestMoodForEmail(string userInput, string expected)
        {
            Validations validations = new Validations();
            string actual = validations.ValidateEmail(userInput);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("91 8857967071", "91 8857967071")]
        [DataRow("8857967071", "Enter Valid Mobile Number")]
        public void TestMoodForMobileNumber(string userInput, string expected)
        {
            Validations validations = new Validations();
            string actual = validations.ValidateMobileNumber(userInput);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("passwordS123_", "passwordS123_")]
        [DataRow("pass", "Enter Valid Password")]
        public void TestMoodForPassoword(string userInput, string expected)
        {
            Validations validations = new Validations();
            string actual = validations.ValidatePassword(userInput);
            Assert.AreEqual(expected, actual);
        }
    }
}
