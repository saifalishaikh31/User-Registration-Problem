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
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", "Enter Valid Email")]
        [DataRow("abc@.com.my", "Enter Valid Email")]
        [DataRow("abc123@.com", "Enter Valid Email")]
        [DataRow("abc123@.com.com", "Enter Valid Email")]
        [DataRow("abc()*@gmail.com", "Enter Valid Email")]
        [DataRow(".abc@abc.com", "Enter Valid Email")]
        [DataRow("abc@%*.com", "Enter Valid Email")]
        [DataRow("abc..2002@gmail.com", "Enter Valid Email")]
        [DataRow("abc.@gmail.com", "Enter Valid Email")]
        [DataRow("abc@abc@gmail.com", "Enter Valid Email")]
        [DataRow("abc@gmail.com.1a", "Enter Valid Email")]
        [DataRow("abc@gmail.com.aa.au", "Enter Valid Email")]
        public void TestMoodForAllEmailSamples(string userInput, string expected)
        {
            Validations validations = new Validations();
            string actual = validations.ValidateEmail(userInput);
            Assert.AreEqual(expected, actual);
        }
    }
}
