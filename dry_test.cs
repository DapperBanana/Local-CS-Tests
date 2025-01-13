
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System");
        
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your email address: ");
        string email = Console.ReadLine();
        
        Console.Write("Enter your phone number: ");
        string phoneNumber = Console.ReadLine();
        
        Console.WriteLine("\nPlease answer the following questions:");
        
        Console.Write("Why are you interested in this position? ");
        string reason = Console.ReadLine();
        
        Console.Write("What is your relevant work experience? ");
        string experience = Console.ReadLine();
        
        Console.Write("What skills do you possess that make you a good fit for this job? ");
        string skills = Console.ReadLine();
        
        Console.WriteLine("\nThank you for applying! Your application has been submitted.");
        
        Console.WriteLine("\nApplicant Information:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Phone Number: " + phoneNumber);
        
        Console.WriteLine("\nAnswers to Questions:");
        Console.WriteLine("1. Why are you interested in this position? " + reason);
        Console.WriteLine("2. What is your relevant work experience? " + experience);
        Console.WriteLine("3. What skills do you possess that make you a good fit for this job? " + skills);
    }
}
