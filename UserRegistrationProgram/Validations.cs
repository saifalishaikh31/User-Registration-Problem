using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class Validations
    {
       
        public string ValidateFirstName(string firstName)
        {
            try
            {
                Regex reg = new Regex("^[A-Z]{1}[a-z]{2,}$");
                if (reg.IsMatch(firstName) && firstName.Length >= 3)
                {
                    Console.WriteLine("Your First Name is : {0}", firstName);
                    return firstName;
                }
                else
                {
                    Console.WriteLine("Enter Valid First Name!!!");
                    Console.WriteLine("Error : It should start with 'Capital letter' and must be greater than 2 words!!!\n");
                    //return "Enter Valid First Name";
                    throw new CustomException(CustomException.CustomExceptionType.INVALID_FIRSTNAME, "Enter Valid First Name");
                }
            }
            catch(CustomException ex)
            {
                return ex.Message;
            }
        }

        public string ValidateLastName(string lastName)
        {
            try
            {
                Regex reg = new Regex("^[A-Z]{1}[a-z]{2,}$");
                if (reg.IsMatch(lastName) && lastName.Length >= 3)
                {
                    Console.WriteLine("Your Last Name is : {0}", lastName);
                    return lastName;
                }
                else
                {
                    Console.WriteLine("Enter Valid Last Name!!!");
                    Console.WriteLine("Error : It should start with 'Capital letter' and must be greater than 2 words!!!\n");
                    //return "Enter Valid Last Name";
                    throw new CustomException(CustomException.CustomExceptionType.INVALID_LASTNAME, "Enter Valid Last Name");
                }
            }
            catch(CustomException ex)
            {
                return ex.Message;
            }
        }

        public string ValidateEmail(string email)
        {
            try
            {
                Regex reg = new Regex("^[A-Z0-9a-z]{1,}([~!&%.#$^_+-][A-Za-z0-9]+)*[@][A-Za-z0-9]{1,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3})?$");
                if (reg.IsMatch(email))
                {
                    Console.WriteLine("Your Email Id is : {0}", email);
                    return email;
                }
                else
                {
                    Console.WriteLine("Enter Valid Email Id!!!");
                    Console.WriteLine("Error : It should contain atleast one 'Capital letter' and one 'Small letter' and one 'Number'!!!\n");
                    //return "Enter Valid Email";
                    throw new CustomException(CustomException.CustomExceptionType.INVALID_EMAIL_ADDRESS, "Enter Valid Email");
                }
            }
            catch(CustomException ex)
            {
                return ex.Message;
            }
        }

        public string ValidateMobileNumber(string mobileNo)
        {
            try
            {
                Regex reg = new Regex("^[9][1][ ]{1}([6-9]{1}[0-9]{9})$");
                if (reg.IsMatch(mobileNo))
                {
                    Console.WriteLine("Your Mobile Number is : {0}", mobileNo);
                    return mobileNo;
                }
                else
                {
                    Console.WriteLine("Enter Valid Mobile Number!!!");
                    Console.WriteLine("Error : It should start with '91' and must contain total 12 Digits For eg : 91 9287654356 \n");
                    //return "Enter Valid Mobile Number";
                    throw new CustomException(CustomException.CustomExceptionType.INVALID_PHONE_NUMBER, "Enter Valid Mobile Number");
                }
            }
            catch(CustomException ex)
            {
                return ex.Message;
            }
        }
        public string ValidatePassword(string password)
        {
            try
            {
                Regex reg = new Regex("^[A-Za-z0-9]{8,}([A-Z0-9][~!&%.#$^_+-]{1})$");
                //Regex reg = new Regex("(?=.*[0-9])(?=.*[A-Z])(?=.*[@#$%]).[A-Z0-9a-z@#$%]{8,}");
                if (reg.IsMatch(password))
                {
                    Console.WriteLine("Your Password is : {0}", password);
                    return password;
                }
                else
                {
                    Console.WriteLine("Enter Valid Password!!!");
                    Console.WriteLine("Error : It should atleat contain 8 digits"
                                    + "\nand atleat one 'Upper Case Letter'"
                                    + "\nand atleast one 'Numeric Number' "
                                    + "\nand exactly one 'special character' (eg : ~ ! & % . # $ ^ _ + - )\n");
                    //return "Enter Valid Password";
                    throw new CustomException(CustomException.CustomExceptionType.INVALID_PASSWORD, "Enter Valid Password");
                }
            }
            catch(CustomException ex)
            {
                return ex.Message;
            }
        }

        public void ClearAllEmail()
        {
            string[] emailsA = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            Console.WriteLine("\nValid Emails : ");
            Check(emailsA);
            string[] emailsB = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            Console.WriteLine("\nInValid Emails : ");
            Check(emailsB);
        }
        public void Check(string[] eMail)
        {
            string[] checkEmail = eMail;
            Regex reg = new Regex("^[A-Z0-9a-z]{1,}([~!&%.#$^_+-][A-Za-z0-9]+)*[@][A-Za-z0-9]{1,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3})?$");
            foreach (string email in checkEmail)
            {
                if (reg.IsMatch(email))
                {
                    Console.WriteLine("Your Email Id is : {0}", email);
                }
                else
                {
                    Console.WriteLine("InValid Email Id : {0}", email);
                }
            }
        }
    }
}
