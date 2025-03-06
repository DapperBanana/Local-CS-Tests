
using System;

class JobApplicationSystem
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System!");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your desired position: ");
        string position = Console.ReadLine();

        Console.Write("Enter your years of experience: ");
        int yearsOfExperience = int.Parse(Console.ReadLine());

        Console.Write("Enter your education level: ");
        string educationLevel = Console.ReadLine();

        Console.WriteLine("Thank you for applying, {0}!", name);
        Console.WriteLine("Position: {0}", position);
        Console.WriteLine("Years of experience: {0}", yearsOfExperience);
        Console.WriteLine("Education level: {0}", educationLevel);

        if (yearsOfExperience >= 3 && educationLevel == "Bachelor's degree")
        {
            Console.WriteLine("Congratulations! You qualify for the position.");
        }
        else
        {
            Console.WriteLine("Sorry, you do not meet the requirements for the position.");
        }
    }
}
