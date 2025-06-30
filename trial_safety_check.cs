
using System;

class Program
{
    static void Main()
    {
        int steps = 0;
        int caloriesBurned = 0;

        while (true)
        {
            Console.WriteLine("Fitness Tracker Menu:");
            Console.WriteLine("1. Add steps");
            Console.WriteLine("2. View steps");
            Console.WriteLine("3. View calories burned");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter number of steps: ");
                    int newSteps = int.Parse(Console.ReadLine());
                    steps += newSteps;
                    caloriesBurned += newSteps / 20; 
                    Console.WriteLine("Steps added successfully!");
                    break;
                case 2:
                    Console.WriteLine("Total steps: " + steps);
                    break;
                case 3:
                    Console.WriteLine("Total calories burned: " + caloriesBurned);
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
