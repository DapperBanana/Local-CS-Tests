
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

    public void RecordSteps(int numSteps)
    {
        steps += numSteps;
        caloriesBurned += numSteps / 20;
        distance += numSteps / 1000;
        Console.WriteLine("Steps recorded: " + numSteps);
    }

    public void DisplayStats()
    {
        Console.WriteLine("Total Steps: " + steps);
        Console.WriteLine("Calories Burned: " + caloriesBurned);
        Console.WriteLine("Distance Covered (km): " + distance);
    }
}

class Program
{
    static void Main()
    {
        FitnessTracker tracker = new FitnessTracker();

        while (true)
        {
            Console.WriteLine("1. Record Steps");
            Console.WriteLine("2. Display Stats");
            Console.WriteLine("3. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter number of steps: ");
                    int numSteps = Convert.ToInt32(Console.ReadLine());
                    tracker.RecordSteps(numSteps);
                    break;
                case 2:
                    tracker.DisplayStats();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
