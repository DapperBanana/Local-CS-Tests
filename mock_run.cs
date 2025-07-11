
using System;

namespace FitnessTracker
{
    class FitnessProgram
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            int totalCaloriesBurned = 0;

            Console.WriteLine("Welcome to the Fitness Tracker Program!");

            while (true)
            {
                Console.WriteLine("1. Add Steps");
                Console.WriteLine("2. View Total Steps");
                Console.WriteLine("3. Add Calories Burned");
                Console.WriteLine("4. View Total Calories Burned");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter number of steps: ");
                        int steps = int.Parse(Console.ReadLine());
                        totalSteps += steps;
                        break;
                    case 2:
                        Console.WriteLine("Total steps taken: " + totalSteps);
                        break;
                    case 3:
                        Console.Write("Enter number of calories burned: ");
                        int caloriesBurned = int.Parse(Console.ReadLine());
                        totalCaloriesBurned += caloriesBurned;
                        break;
                    case 4:
                        Console.WriteLine("Total calories burned: " + totalCaloriesBurned);
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using the Fitness Tracker Program!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
