
using System;

class JobApplication
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }
    public string Resume { get; set; }

    public JobApplication(string name, string email, string position, string resume)
    {
        Name = name;
        Email = email;
        Position = position;
        Resume = resume;
    }

    public void DisplayApplication()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Position: " + Position);
        Console.WriteLine("Resume: " + Resume);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        Console.Write("Enter the position you are applying for: ");
        string position = Console.ReadLine();

        Console.Write("Enter your resume: ");
        string resume = Console.ReadLine();

        JobApplication application = new JobApplication(name, email, position, resume);

        Console.WriteLine("\nYour job application details:");
        application.DisplayApplication();
    }
}
