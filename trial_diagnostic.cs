
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System\n");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your desired position: ");
        string position = Console.ReadLine();

        Console.Write("Enter your years of experience: ");
        int experience = int.Parse(Console.ReadLine());

        Console.Write("Enter your expected salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("\nThank you for submitting your application!");
        Console.WriteLine("\nApplicant: " + name);
        Console.WriteLine("Desired Position: " + position);
        Console.WriteLine("Years of Experience: " + experience);
        Console.WriteLine("Expected Salary: $" + salary);
    }
}
