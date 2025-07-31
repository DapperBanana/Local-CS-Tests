
using System;

class FitnessTracker
{
    static void Main(string[] args)
    {
        int totalSteps = 0;
        int totalCalories = 0;
        
        while (true)
        {
            Console.WriteLine("Welcome to Fitness Tracker!");
            Console.WriteLine("1. Log Steps");
            Console.WriteLine("2. Log Calories Burned");
            Console.WriteLine("3. View Summary");
            Console.WriteLine("4. Exit");
            
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.Write("Enter number of steps taken: ");
                    int steps = Convert.ToInt32(Console.ReadLine());
                    totalSteps += steps;
                    Console.WriteLine("Steps logged successfully!");
                    break;
                case 2:
                    Console.Write("Enter number of calories burned: ");
                    int calories = Convert.ToInt32(Console.ReadLine());
                    totalCalories += calories;
                    Console.WriteLine("Calories logged successfully!");
                    break;
                case 3:
                    Console.WriteLine("Fitness Summary:");
                    Console.WriteLine("Total Steps: " + totalSteps);
                    Console.WriteLine("Total Calories Burned: " + totalCalories);
                    break;
                case 4:
                    Console.WriteLine("Thank you for using Fitness Tracker. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
