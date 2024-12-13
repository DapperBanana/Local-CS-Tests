
using System;

class Program
{
    static void Main()
    {
        int caloriesConsumed = 0;
        int caloriesBurned = 0;
        int totalSteps = 0;

        while (true)
        {
            Console.WriteLine("Fitness Tracking System");
            Console.WriteLine("1. Record calories consumed");
            Console.WriteLine("2. Record calories burned");
            Console.WriteLine("3. Record steps taken");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter number of calories consumed: ");
                    caloriesConsumed += Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter number of calories burned: ");
                    caloriesBurned += Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter number of steps taken: ");
                    totalSteps += Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Summary:");
                    Console.WriteLine("Calories Consumed: " + caloriesConsumed);
                    Console.WriteLine("Calories Burned: " + caloriesBurned);
                    Console.WriteLine("Total Steps: " + totalSteps);
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
