
using System;

class Program
{
    static int caloriesBurned = 0;
    static int stepsTaken = 0;

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to the Fitness Tracking System");
            Console.WriteLine("1. Log calories burned");
            Console.WriteLine("2. Log steps taken");
            Console.WriteLine("3. View daily summary");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LogCaloriesBurned();
                    break;
                case 2:
                    LogStepsTaken();
                    break;
                case 3:
                    ViewDailySummary();
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void LogCaloriesBurned()
    {
        Console.Write("Enter the number of calories burned: ");
        int calories = Convert.ToInt32(Console.ReadLine());
        caloriesBurned += calories;
    }

    static void LogStepsTaken()
    {
        Console.Write("Enter the number of steps taken: ");
        int steps = Convert.ToInt32(Console.ReadLine());
        stepsTaken += steps;
    }

    static void ViewDailySummary()
    {
        Console.WriteLine("Daily Summary:");
        Console.WriteLine("Calories Burned: " + caloriesBurned);
        Console.WriteLine("Steps Taken: " + stepsTaken);
    }
}
