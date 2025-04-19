
using System;

namespace JobApplicationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Job Application System!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter your previous work experience: ");
            string workExperience = Console.ReadLine();

            Console.WriteLine("\nThank you for submitting your application!");
            Console.WriteLine("Here is the information you provided:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Work Experience: " + workExperience);

            Console.WriteLine("\nWe will review your application and get back to you soon.");
        }
    }
}
