
using System;

class Program
{
    static void Main()
    {
        int steps = 0;
        int calories = 0;

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add steps");
            Console.WriteLine("2. Add calories");
            Console.WriteLine("3. View total steps and calories");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter number of steps: ");
                    steps += int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter number of calories burned: ");
                    calories += int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine($"Total steps: {steps}");
                    Console.WriteLine($"Total calories burned: {calories}");
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
