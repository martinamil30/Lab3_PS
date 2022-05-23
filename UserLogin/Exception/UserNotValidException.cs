using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    public class UserNotValidException : Exception
    {
        public UserNotValidException()
        {

        }

        public UserNotValidException(string message) : base(message)
        {

        }

        public UserNotValidException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}