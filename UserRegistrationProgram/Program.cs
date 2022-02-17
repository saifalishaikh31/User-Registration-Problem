  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            Validations validate = new Validations();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("\n1.First Name Validation."
                              + "\n2.Last Name Validation"
                              + "\n3.Email Id Validation"
                              + "\n4.Mobile Number Validation"
                              + "\n5.Password Validation"
                              + "\n0.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        validate.ValidateFirstName();
                        break;
                    case 2:
                        validate.ValidateLastName();
                        break;
                    case 3:
                        validate.ValidateEmail();
                        break;
                    case 4:
                        validate.ValidateMobileNumber();
                        break;
                    case 5:
                        validate.ValidatePassword();
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option!!!");
                        break;
                }
            }
        }
    }
}
