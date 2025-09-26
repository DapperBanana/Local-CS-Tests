
using System;

namespace JobApplicationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Job Application System!");

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter your desired job position: ");
            string jobPosition = Console.ReadLine();

            Console.WriteLine("\nThank you for applying! Here is the information you provided:");
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.WriteLine("Desired Job Position: " + jobPosition);

            Console.WriteLine("\nYour application has been submitted. We will be in touch if you are selected for an interview. Good luck!");
        }
    }
}
