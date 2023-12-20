using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagerStudentApp.Controller
{
    internal class CUserInputValidator
    {
        static public bool IsTextBoxEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        static public bool IsEmailValid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9_.-]+@[a-zA-Z0-9.-]+\.com$";
            return Regex.IsMatch(email, emailPattern);
        }

        static public bool IsPhoneNumberValid(string phoneNumber)
        {
                string phonePattern = @"\d{10,12}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}
