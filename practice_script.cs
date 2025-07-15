
using System;

class JobApplicationSystem
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System");
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter your email:");
        string email = Console.ReadLine();

        Console.WriteLine("Please enter your phone number:");
        string phone = Console.ReadLine();

        Console.WriteLine("Please enter your desired job position:");
        string jobPosition = Console.ReadLine();

        Console.WriteLine("Thank you for submitting your application!");
        Console.WriteLine("Application Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Phone: " + phone);
        Console.WriteLine("Desired Job Position: " + jobPosition);
    }
}
