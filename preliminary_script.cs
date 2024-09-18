
using System;

class JobApplicationSystem
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        Console.Write("Enter your phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Enter your desired position: ");
        string position = Console.ReadLine();

        Console.WriteLine("\nThank you for submitting your application!");
        Console.WriteLine("Here are the details you entered:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Desired Position: " + position);
    }
}
