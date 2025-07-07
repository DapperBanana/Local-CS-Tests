
using System;
using System.Collections.Generic;

class FitnessTracker
{
    static void Main()
    {
        Dictionary<string, int> exercises = new Dictionary<string, int>();

        while (true)
        {
            Console.WriteLine("Welcome to the fitness tracking system");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add exercise");
            Console.WriteLine("2. View exercises");
            Console.WriteLine("3. Exit");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter exercise name: ");
                    string exerciseName = Console.ReadLine();

                    Console.Write("Enter exercise duration (in minutes): ");
                    int exerciseDuration = Convert.ToInt32(Console.ReadLine());

                    if (exercises.ContainsKey(exerciseName))
                    {
                        exercises[exerciseName] += exerciseDuration;
                    }
                    else
                    {
                        exercises.Add(exerciseName, exerciseDuration);
                    }

                    Console.WriteLine("Exercise added successfully!");
                    break;

                case 2:
                    Console.WriteLine("Exercise log:");
                    foreach (var exercise in exercises)
                    {
                        Console.WriteLine($"Exercise: {exercise.Key} - Duration: {exercise.Value} minutes");
                    }
                    break;

                case 3:
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
