using System;

namespace UserRegistrationException
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string EmailValidation;
            Console.Write("Enter your EmailId:\n");
            EmailValidation = Console.ReadLine();
            RegexProblem.checkEmailValidation(EmailValidation);
        }
    }
}
