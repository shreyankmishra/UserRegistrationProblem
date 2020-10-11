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
        public static string Regex_Password = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&*+-.]*[!@#$%&*+-.][^!@#$%&*+-.]*$)[\\S]{8,}$";
        private static string Regex_EmailAll = "^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
        public List<string> sampleEmails = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };
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
        public bool ValidateEmailSamples(string emailId)
        {
            return Regex.IsMatch(emailId, Regex_EmailAll);
        }
        public List<string> GetList()
        {
            return sampleEmails;
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
