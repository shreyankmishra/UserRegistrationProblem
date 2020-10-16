using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
       public class InvalidUserDetailsCustomException : Exception
        {
            public enum CustomExceptionType
            {
                INVALID_FIRST_NAME,
                INVALID_LAST_NAME,
                INVALID_EMAIL,
                INVALID_MOBILE_NUMBER,
                INVALID_PASSWORD
            }
            private CustomExceptionType type;
            public InvalidUserDetailsCustomException(CustomExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
    }

