
using System;

class JobApplicationSystem
{
    static void Main()
    {
        string name, email, jobTitle;
        int yearsExperience;
        bool hasExperience;

        Console.WriteLine("Welcome to the Job Application System");

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your email address: ");
        email = Console.ReadLine();

        Console.Write("Enter the job title you are applying for: ");
        jobTitle = Console.ReadLine();

        Console.Write("Enter the number of years of experience you have: ");
        yearsExperience = int.Parse(Console.ReadLine());

        Console.Write("Do you have any relevant experience? (true/false): ");
        hasExperience = bool.Parse(Console.ReadLine());

        Console.WriteLine("\nThank you for submitting your application!");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Job Title: " + jobTitle);
        Console.WriteLine("Years of Experience: " + yearsExperience);
        Console.WriteLine("Has Relevant Experience: " + hasExperience);
    }
}
