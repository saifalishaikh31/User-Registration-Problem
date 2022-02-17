using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    internal class Validations
    {
        public void ValidateFirstName()
        {
            Regex reg = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.Write("Enter First Name : ");
            string fname = Console.ReadLine();
            if (reg.IsMatch(fname) && fname.Length >= 3)
            {
                Console.WriteLine("Your First Name is : {0}", fname);
            }
            else
            {
                Console.WriteLine("Enter Valid First Name!!!");
                Console.WriteLine("Error : It should start with 'Capital letter' and must be greater than 2 words!!!\n");
            }
        }

        public void ValidateLastName()
        {
            Regex reg = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.Write("Enter Last Name : ");
            string lname = Console.ReadLine();
            if (reg.IsMatch(lname) && lname.Length >= 3)
            {
                Console.WriteLine("Your Last Name is : {0}", lname);
            }
            else
            {
                Console.WriteLine("Enter Valid Last Name!!!");
                Console.WriteLine("Error : It should start with 'Capital letter' and must be greater than 2 words!!!\n");
            }
        }

        public void ValidateEmail()
        {
            Regex reg = new Regex("^[A-Z0-9a-z]{1,}([.#$^_+-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$");
            Console.Write("Enter Email Id : ");
            string email = Console.ReadLine();
            if (reg.IsMatch(email))
            {
                Console.WriteLine("Your Email Id is : {0}", email);
            }
            else
            {
                Console.WriteLine("Enter Valid Email Id!!!");
                Console.WriteLine("Error : It should contain atleast one 'Capital letter' and one 'Small letter' and one 'Number'!!!\n");
            }
        }
    }
}
