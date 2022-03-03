using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class CustomException : Exception
    {
        public enum CustomExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL_ADDRESS,
            INVALID_PHONE_NUMBER,
            INVALID_PASSWORD
        }
        public CustomExceptionType customExceptionType;
        public CustomException(CustomExceptionType type, string message) : base(message)
        {
            this.customExceptionType = type;
        }
    }
}
