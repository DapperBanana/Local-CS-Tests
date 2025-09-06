
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the job application system!");
        
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your desired position: ");
        string position = Console.ReadLine();
        
        Console.Write("Enter your years of experience: ");
        int yearsOfExperience = int.Parse(Console.ReadLine());
        
        Console.Write("Enter your current salary: ");
        double currentSalary = double.Parse(Console.ReadLine());
        
        Console.WriteLine("\n\n===== Job Application Summary =====");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Desired Position: " + position);
        Console.WriteLine("Years of Experience: " + yearsOfExperience);
        Console.WriteLine("Current Salary: " + currentSalary);
        
        if (yearsOfExperience >= 3 && currentSalary <= 50000)
        {
            Console.WriteLine("\nCongratulations! You are eligible for the job position.");
        }
        else
        {
            Console.WriteLine("\nSorry, you do not meet the requirements for the job position.");
        }
        
        Console.WriteLine("\nThank you for applying!");
    }
}
