
using System;

class Program
{
    static void Main()
    {
        int fuel = 100;
        int distance = 0;

        Console.WriteLine("Welcome to the Spaceship Game!");
        
        while (distance < 100)
        {
            Console.WriteLine($"Current fuel level: {fuel}");
            Console.WriteLine($"Current distance travelled: {distance}");

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Accelerate");
            Console.WriteLine("2. Refuel");
            Console.WriteLine("3. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (fuel >= 10)
                    {
                        distance += 10;
                        fuel -= 10;
                        Console.WriteLine("You accelerated and travelled 10 light years!");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to accelerate!");
                    }
                    break;
                case 2:
                    fuel += 50;
                    Console.WriteLine("Refueled by 50 units!");
                    break;
                case 3:
                    Console.WriteLine("Game over. You travelled a total of {0} light years.", distance);
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Congratulations, you have reached your destination!");
    }
}
