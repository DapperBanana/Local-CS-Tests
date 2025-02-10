
using System;

namespace FitnessTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int calories = 0;
            int waterIntake = 0;
            
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Log steps");
                Console.WriteLine("2. Log calories burned");
                Console.WriteLine("3. Log water intake");
                Console.WriteLine("4. View progress");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.Write("Enter number of steps: ");
                        int stepsLogged = Convert.ToInt32(Console.ReadLine());
                        steps += stepsLogged;
                        break;
                    case 2:
                        Console.Write("Enter number of calories burned: ");
                        int caloriesLogged = Convert.ToInt32(Console.ReadLine());
                        calories += caloriesLogged;
                        break;
                    case 3:
                        Console.Write("Enter amount of water intake (in ml): ");
                        int waterIntakeLogged = Convert.ToInt32(Console.ReadLine());
                        waterIntake += waterIntakeLogged;
                        break;
                    case 4:
                        Console.WriteLine($"Steps logged: {steps}");
                        Console.WriteLine($"Calories burned: {calories}");
                        Console.WriteLine($"Water intake: {waterIntake} ml");
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
