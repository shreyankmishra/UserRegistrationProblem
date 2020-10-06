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
        }
    }
}
