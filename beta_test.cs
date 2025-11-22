
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your desired position: ");
        string position = Console.ReadLine();

        Console.Write("Enter your years of experience: ");
        int yearsOfExperience = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThank you for applying!");

        Console.WriteLine("\nApplication Summary:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Desired Position: " + position);
        Console.WriteLine("Years of Experience: " + yearsOfExperience);

        if (yearsOfExperience >= 3)
        {
            Console.WriteLine("Congratulations! You meet the minimum experience requirement.");
        }
        else
        {
            Console.WriteLine("Sorry, you do not meet the minimum experience requirement.");
        }
    }
}
