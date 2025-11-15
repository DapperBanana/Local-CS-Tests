
using System;

class JobApplicationSystem
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your desired position: ");
        string position = Console.ReadLine();

        Console.Write("Enter your years of experience: ");
        int experience = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nThank you for submitting your application!");
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Position: {0}", position);
        Console.WriteLine("Years of Experience: {0}", experience);

        if (experience >= 2)
        {
            Console.WriteLine("\nCongratulations, you meet the minimum experience requirement!");
            Console.WriteLine("We will contact you for further steps.");
        }
        else
        {
            Console.WriteLine("\nUnfortunately, you do not meet the minimum experience requirement.");
            Console.WriteLine("Thank you for your interest in our company.");
        }
    }
}
