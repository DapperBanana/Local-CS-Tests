using System;
using System.Collections.Generic;

namespace JobApplicationSystem
{
    // Class representing a job applicant
    class Applicant
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Resume { get; set; } // For simplicity, a string representing resume details

        public Applicant(string name, string email, string position, string resume)
        {
            Name = name;
            Email = email;
            Position = position;
            Resume = resume;
        }
    }

    // Main class for the job application system
    class Program
    {
        static List<Applicant> applicants = new List<Applicant>();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=== Job Application System ===");
                Console.WriteLine("1. Submit Application");
                Console.WriteLine("2. View All Applications");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option (1-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SubmitApplication();
                        break;
                    case "2":
                        ViewApplications();
                        break;
                    case "3":
                        exit = true;
                        Console.WriteLine("Exiting the system. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void SubmitApplication()
        {
            Console.WriteLine("--- Submit a New Application ---");
            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Position Applied For: ");
            string position = Console.ReadLine();

            Console.Write("Briefly describe your resume/background: ");
            string resume = Console.ReadLine();

            Applicant applicant = new Applicant(name, email, position, resume);
            applicants.Add(applicant);

            Console.WriteLine("Application submitted successfully!");
        }

        static void ViewApplications()
        {
            Console.WriteLine("--- All Job Applications ---");
            if (applicants.Count == 0)
            {
                Console.WriteLine("No applications found.");
                return;
            }

            for (int i = 0; i < applicants.Count; i++)
            {
                Applicant app = applicants[i];
                Console.WriteLine($"Application #{i + 1}");
                Console.WriteLine($"Name: {app.Name}");
                Console.WriteLine($"Email: {app.Email}");
                Console.WriteLine($"Position: {app.Position}");
                Console.WriteLine($"Resume/Bio: {app.Resume}");
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}