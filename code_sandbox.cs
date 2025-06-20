
using System;

class FitnessTracker
{
    static void Main()
    {
        int totalSteps = 0;
        int totalCalories = 0;
        int totalDistance = 0;

        while (true)
        {
            Console.WriteLine("Fitness Tracker Menu:");
            Console.WriteLine("1. Add steps");
            Console.WriteLine("2. Add calories burned");
            Console.WriteLine("3. Add distance traveled");
            Console.WriteLine("4. View totals");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the number of steps: ");
                    int steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;
                    break;
                case 2:
                    Console.Write("Enter the number of calories burned: ");
                    int calories = int.Parse(Console.ReadLine());
                    totalCalories += calories;
                    break;
                case 3:
                    Console.Write("Enter the distance traveled (in miles): ");
                    int distance = int.Parse(Console.ReadLine());
                    totalDistance += distance;
                    break;
                case 4:
                    Console.WriteLine("Total Steps: " + totalSteps);
                    Console.WriteLine("Total Calories Burned: " + totalCalories);
                    Console.WriteLine("Total Distance Traveled: " + totalDistance + " miles");
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
