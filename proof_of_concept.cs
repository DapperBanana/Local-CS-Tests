
using System;

class FitnessTracker
{
    private int totalSteps;
    private int totalCaloriesBurned;
    private int totalDistance;

    public FitnessTracker()
    {
        totalSteps = 0;
        totalCaloriesBurned = 0;
        totalDistance = 0;
    }

    public void AddSteps(int steps)
    {
        totalSteps += steps;
        totalCaloriesBurned += steps / 20; // Assuming 20 steps burn 1 calorie
        totalDistance += steps * 2; // Assuming 2 steps cover 1 meter
    }

    public void DisplayStats()
    {
        Console.WriteLine("Total Steps: " + totalSteps);
        Console.WriteLine("Total Calories Burned: " + totalCaloriesBurned);
        Console.WriteLine("Total Distance Covered: " + totalDistance + " meters");
    }
}

class Program
{
    static void Main()
    {
        FitnessTracker tracker = new FitnessTracker();

        while (true)
        {
            Console.WriteLine("Enter the number of steps taken (or -1 to exit): ");
            int steps = Convert.ToInt32(Console.ReadLine());

            if (steps == -1)
            {
                break;
            }

            tracker.AddSteps(steps);
            tracker.DisplayStats();
        }
    }
}
