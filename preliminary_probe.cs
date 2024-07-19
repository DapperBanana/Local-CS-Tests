
using System;

namespace JobApplicationSystem
{
    class Program
    {
        static string jobTitle;
        static string applicantName;
        static string applicantEmail;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Job Application System!");

            GetJobDetails();
            GetApplicantDetails();

            Console.WriteLine("\nThank you for submitting your job application for the position of {0}.", jobTitle);
            Console.WriteLine("We will review your application and get back to you soon.");

            Console.ReadLine();
        }

        static void GetJobDetails()
        {
            Console.WriteLine("\nPlease enter the job title you are applying for:");
            jobTitle = Console.ReadLine();
        }

        static void GetApplicantDetails()
        {
            Console.WriteLine("\nPlease enter your full name:");
            applicantName = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");
            applicantEmail = Console.ReadLine();
        }
    }
}
