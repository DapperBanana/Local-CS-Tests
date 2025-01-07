
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System\n");

        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        Console.Write("Enter your desired job position: ");
        string jobPosition = Console.ReadLine();

        Console.Write("Enter your years of experience: ");
        int yearsOfExperience;
        while (!int.TryParse(Console.ReadLine(), out yearsOfExperience))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for years of experience.");
        }

        Console.WriteLine("\nThank you for submitting your application.");
        Console.WriteLine("Here is the information you provided:");
        Console.WriteLine("Full Name: " + fullName);
        Console.WriteLine("Desired Job Position: " + jobPosition);
        Console.WriteLine("Years of Experience: " + yearsOfExperience);
    }
}
