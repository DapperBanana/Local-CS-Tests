
using System;
using System.Collections.Generic;

namespace FitnessTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> fitnessData = new Dictionary<string, int>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("Fitness Tracking System");
                Console.WriteLine("1. Log a new workout");
                Console.WriteLine("2. View total number of workouts");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the type of workout: ");
                        string workout = Console.ReadLine();
                        if (fitnessData.ContainsKey(workout))
                        {
                            fitnessData[workout]++;
                        }
                        else
                        {
                            fitnessData.Add(workout, 1);
                        }
                        Console.WriteLine("Workout logged successfully!");
                        break;

                    case 2:
                        foreach (KeyValuePair<string, int> entry in fitnessData)
                        {
                            Console.WriteLine(entry.Key + ": " + entry.Value);
                        }
                        break;

                    case 3:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
