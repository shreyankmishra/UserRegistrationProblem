using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class RegexValidate
    {
        public static string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_Email = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public static string Regex_MobileNo = "^[1-9]{1}[0-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        public static string Regex_Password = "^(?=.*?[A-Z])(?=.*?[0-9])[A-Za-z0-9!@#$%^&*]{8,}$";
        public bool ValidateFirstName(string first)
        {
            return Regex.IsMatch(first, Regex_FirstName);
        }
        public bool ValidateLastName(string last)
        {
            return Regex.IsMatch(last, Regex_LastName);
        }
        public bool ValidateEmail(string emailId)
        {
            return Regex.IsMatch(emailId, Regex_Email);
        }
        public bool ValidateMobileNo(string mobileNo)
        {
            return Regex.IsMatch(mobileNo, Regex_MobileNo);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
}
