
using System;

class FitnessTracker
{
    private int steps;
    private double distance;

    public FitnessTracker()
    {
        steps = 0;
        distance = 0;
    }

    public void AddSteps(int newSteps)
    {
        steps += newSteps;
    }

    public void CalculateDistance()
    {
        distance = steps * 0.000762; // Assume each step is approximately 0.000762 meters
    }

    public void DisplayFitnessData()
    {
        Console.WriteLine($"Total steps: {steps}");
        Console.WriteLine($"Total distance: {distance} km");
    }

    static void Main()
    {
        FitnessTracker tracker = new FitnessTracker();

        tracker.AddSteps(2000);
        tracker.CalculateDistance();
        tracker.DisplayFitnessData();
    }
}
