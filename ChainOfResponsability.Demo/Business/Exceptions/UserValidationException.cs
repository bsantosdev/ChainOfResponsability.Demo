using System;

namespace ChainOfResponsability.Demo.Business.Exceptions
{
    public class UserValidationException : Exception
    {
        public UserValidationException(string errorMessage)
        {

        }
    }
}
