using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TimeTrackingApp.Services.Helpers
{
    public class ValidationHelper
    {
        //BONUS: First Name and Last Name should not contain numbers
        //First Name and Last Name should not be shorter than 2 characters
        public static bool ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 2 || name.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        //Username should not be shorter than 5 characters
        public static bool ValidateUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 5)
            {
                return false;
            }
            return true;
        }

        //Password should not be shorter than 6 characters
        //BONUS: Password should contain at least one capital letter
        //BONUS: Password should contain at least one number
        public static bool ValidatePassword(string password)
        {
            //stringName.Any(char.IsDigit)
            if (string.IsNullOrEmpty(password) || password.Length < 6 || !password.Any(char.IsDigit) || !password.Any(char.IsUpper))
            {
                return false;
            }
            return true;
        }

        //Age should not be less than 18 years or over 120
        public static bool ValidateAge(int age)
        {
            //stringName.Any(char.IsDigit)
            if (age < 18 || age > 120)
            {
                return false;
            }
            return true;
        }
    }
}
