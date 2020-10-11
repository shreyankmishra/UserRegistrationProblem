using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidate validateUser = new RegexValidate();
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            bool fNameResult = validateUser.ValidateFirstName(firstName);
            validateUser.PrintResult(fNameResult);
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            bool lNameResult = validateUser.ValidateLastName(lastName);
            validateUser.PrintResult(lNameResult);
            Console.WriteLine("Enter your email id: ");
            string eMailId = Console.ReadLine();
            bool emailResult = validateUser.ValidateEmail(eMailId);
            validateUser.PrintResult(emailResult);
            Console.WriteLine("Enter your mobile no: ");
            string mobileNo = Console.ReadLine();
            bool mobileResult = validateUser.ValidateMobileNo(mobileNo);
            validateUser.PrintResult(mobileResult);
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            bool passwordResult = validateUser.ValidatePassword(password);
            validateUser.PrintResult(passwordResult);
            Console.WriteLine("Check for provided sample Emails: ");
            foreach (string email in validateUser.GetList())
            {
                Console.Write(email + " : ");
                validateUser.PrintResult(validateUser.ValidateEmailSamples(email));
            }
        }
    }
}
