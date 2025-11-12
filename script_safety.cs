
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Spaceship Game!");
        Console.WriteLine("You are in control of a spaceship.\n");
        
        int fuel = 100;
        int position = 0;

        while (true)
        {
            Console.WriteLine("Current Position: " + position);
            Console.WriteLine("Fuel level: " + fuel + "\n");

            Console.WriteLine("1. Move forward");
            Console.WriteLine("2. Refuel");
            Console.WriteLine("3. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                if (fuel >= 10)
                {
                    position += 10;
                    fuel -= 10;
                    Console.WriteLine("You moved forward 10 units.\n");
                }
                else
                {
                    Console.WriteLine("Not enough fuel to move forward.\n");
                }
            }
            else if (choice == 2)
            {
                fuel = 100;
                Console.WriteLine("Fuel refilled.\n");
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.\n");
            }

        }

        Console.WriteLine("Game Over. Your final position was: " + position);
    }
}
