using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Messaging_System_WPF.Utilities
{
    public static class ValidationUtils
    {
        public static bool IsNullOrEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsValidEmail(string email)
        {
            // Implement your email validation logic here
            // You can use regular expressions or any other method to validate the email format
            throw new NotImplementedException();
        }

        public static bool IsValidPassword(string password)
        {
            // Implement your password validation logic here
            // You can check for password length, complexity, or any other requirements
            throw new NotImplementedException();
        }
    }
}
