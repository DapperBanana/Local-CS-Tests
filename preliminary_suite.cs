
using System;

namespace FitnessTrackingSystem
{
    class Program
    {
        static int steps = 0;
        static int caloriesBurned = 0;

        static void Main(string[] args)
        {
            bool running = true;

            Console.WriteLine("Welcome to Fitness Tracking System!");

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add steps");
                Console.WriteLine("2. View total steps and calories burned");
                Console.WriteLine("3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddSteps();
                        break;
                    case 2:
                        ViewSummary();
                        break;
                    case 3:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddSteps()
        {
            Console.WriteLine("Enter the number of steps: ");
            int newSteps = Convert.ToInt32(Console.ReadLine());
            steps += newSteps;
            caloriesBurned += newSteps / 20; // Assuming 1 step burns 20 calories
            Console.WriteLine("Steps added successfully!");
        }

        static void ViewSummary()
        {
            Console.WriteLine($"Total steps: {steps}");
            Console.WriteLine($"Total calories burned: {caloriesBurned}");
        }
    }
}
