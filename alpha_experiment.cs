
using System;

class FitnessTracker
{
    private int caloriesBurned;
    private int stepsTaken;

    public FitnessTracker()
    {
        caloriesBurned = 0;
        stepsTaken = 0;
    }

    public void AddCalories(int calories)
    {
        caloriesBurned += calories;
    }

    public void AddSteps(int steps)
    {
        stepsTaken += steps;
    }

    public void DisplayStats()
    {
        Console.WriteLine("Fitness Tracker Stats:");
        Console.WriteLine($"Calories Burned: {caloriesBurned}");
        Console.WriteLine($"Steps Taken: {stepsTaken}");
    }
}

class Program
{
    static void Main()
    {
        FitnessTracker tracker = new FitnessTracker();

        tracker.AddCalories(150);
        tracker.AddSteps(5000);

        tracker.DisplayStats();
    }
}
