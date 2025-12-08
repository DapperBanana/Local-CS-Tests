using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    class Program
    {
        static Dictionary<string, List<Workout>> userWorkouts = new Dictionary<string, List<Workout>>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Fitness Tracking System!");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add new user's workout");
                Console.WriteLine("2. View a user's workouts");
                Console.WriteLine("3. Exit");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddWorkout();
                        break;
                    case "2":
                        ViewWorkouts();
                        break;
                    case "3":
                        Console.WriteLine("Exiting. Stay healthy!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddWorkout()
        {
            Console.Write("Enter user's name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter workout type (e.g., Cardio, Strength): ");
            string workoutType = Console.ReadLine();

            Console.Write("Enter duration in minutes: ");
            if (!int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Invalid duration. Workout not added.");
                return;
            }

            Console.Write("Enter date (YYYY-MM-DD): ");
            string dateStr = Console.ReadLine();
            if (!DateTime.TryParse(dateStr, out DateTime date))
            {
                Console.WriteLine("Invalid date format. Workout not added.");
                return;
            }

            Workout newWorkout = new Workout
            {
                Type = workoutType,
                DurationMinutes = duration,
                Date = date
            };

            if (!userWorkouts.ContainsKey(userName))
            {
                userWorkouts[userName] = new List<Workout>();
            }
            userWorkouts[userName].Add(newWorkout);
            Console.WriteLine("Workout added successfully.");
        }

        static void ViewWorkouts()
        {
            Console.Write("Enter user's name to view workouts: ");
            string userName = Console.ReadLine();

            if (!userWorkouts.ContainsKey(userName) || userWorkouts[userName].Count == 0)
            {
                Console.WriteLine($"No workouts found for {userName}.");
                return;
            }

            Console.WriteLine($"\nWorkouts for {userName}:");
            foreach (var workout in userWorkouts[userName])
            {
                Console.WriteLine($"- {workout.Date.ToShortDateString()}: {workout.Type} for {workout.DurationMinutes} minutes");
            }
        }
    }

    class Workout
    {
        public string Type { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime Date { get; set; }
    }
}