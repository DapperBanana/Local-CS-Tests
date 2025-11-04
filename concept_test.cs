
using System;

class Program
{
    static void Main(string[] args)
    {
        // Job application form
        Console.WriteLine("Welcome to the job application system\n");

        // Get user input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your email address: ");
        string email = Console.ReadLine();

        Console.Write("Enter your phone number: ");
        string phone = Console.ReadLine();

        Console.WriteLine("\nJob positions available:");
        Console.WriteLine("1. Software Developer");
        Console.WriteLine("2. Data Analyst");
        Console.WriteLine("3. Customer Service Representative");

        Console.Write("Enter the job position you are applying for (1/2/3): ");
        int position = Convert.ToInt32(Console.ReadLine());

        // Display summary of application
        Console.WriteLine("\nApplication Summary:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Phone Number: " + phone);

        string jobTitle = "";
        switch (position)
        {
            case 1:
                jobTitle = "Software Developer";
                break;
            case 2:
                jobTitle = "Data Analyst";
                break;
            case 3:
                jobTitle = "Customer Service Representative";
                break;
            default:
                jobTitle = "Unknown";
                break;
        }
        Console.WriteLine("Job Position: " + jobTitle);

        // Thank you message
        Console.WriteLine("\nThank you for applying! Your application has been submitted.");
    }
}
