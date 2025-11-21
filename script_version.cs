
using System;

class FitnessTracker
{
    private int steps;
    private int caloriesBurned;

    public FitnessTracker()
    {
        steps = 0;
        caloriesBurned = 0;
    }

    public void RecordSteps(int numSteps)
    {
        steps += numSteps;
        caloriesBurned += numSteps / 20; // Assuming 20 steps burn 1 calorie
    }

    public void ShowStats()
    {
        Console.WriteLine("Total Steps: " + steps);
        Console.WriteLine("Calories Burned: " + caloriesBurned);
    }
}

class Program
{
    static void Main()
    {
        FitnessTracker tracker = new FitnessTracker();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Enter the number of steps you took (or type 'quit' to exit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                running = false;
            }
            else
            {
                if (int.TryParse(input, out int numSteps))
                {
                    tracker.RecordSteps(numSteps);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or type 'quit' to exit.");
                }
            }
        }

        tracker.ShowStats();
    }
}
