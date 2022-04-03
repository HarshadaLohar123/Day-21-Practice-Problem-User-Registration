using System;

namespace UserRegistrationException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string Email;
            Console.Write("Enter your Email ID : ");
            Email = Console.ReadLine();
            RegexProblem.checkFirstName(Email);
        }
    }
}
