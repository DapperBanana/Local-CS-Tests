
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Applicant> applicants = new List<Applicant>();

        while (true)
        {
            Console.WriteLine("Welcome to the Job Application System");
            Console.WriteLine("1. Apply for a job");
            Console.WriteLine("2. View all applicants");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your email address:");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter your desired job title:");
                    string jobTitle = Console.ReadLine();

                    // Create a new Applicant object
                    Applicant newApplicant = new Applicant(name, email, jobTitle);
                    applicants.Add(newApplicant);
                    Console.WriteLine("Thank you for applying!");

                    break;
                case 2:
                    Console.WriteLine("All applicants:");
                    foreach (var applicant in applicants)
                    {
                        Console.WriteLine($"Name: {applicant.Name}, Email: {applicant.Email}, Desired Job Title: {applicant.JobTitle}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}

class Applicant
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string JobTitle { get; set; }

    public Applicant(string name, string email, string jobTitle)
    {
        Name = name;
        Email = email;
        JobTitle = jobTitle;
    }
}
