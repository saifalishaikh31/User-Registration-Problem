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
                Console.WriteLine("It should start with 'Capital letter' and must be greater than 2 words!!!");
            }
        }
    }
}
