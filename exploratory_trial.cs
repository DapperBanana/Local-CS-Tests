
using System;

class FitnessTracker
{
    private int steps;
    private int caloriesBurned;
    private int distance;

    public FitnessTracker()
    {
        steps = 0;
        caloriesBurned = 0;
        distance = 0;
    }

    public void AddSteps(int numSteps)
    {
        steps += numSteps;
        caloriesBurned += numSteps / 20;
        distance += numSteps / 1000;
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Steps: {steps}");
        Console.WriteLine($"Calories Burned: {caloriesBurned}");
        Console.WriteLine($"Distance (in km): {distance}");
    }
}

class Program
{
    static void Main()
    {
        FitnessTracker tracker = new FitnessTracker();

        bool tracking = true;
        while (tracking)
        {
            Console.WriteLine("Enter the number of steps taken (or type 'exit' to end tracking): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                tracking = false;
            }
            else
            {
                int numSteps;
                if (int.TryParse(input, out numSteps))
                {
                    tracker.AddSteps(numSteps);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of steps.");
                }
            }
        }

        Console.WriteLine("Fitness tracking complete. Here are your final stats:");
        tracker.DisplayStats();
    }
}
