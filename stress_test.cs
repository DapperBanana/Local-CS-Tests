
using System;

class Program
{
    static void Main()
    {
        int fuel = 100;
        int health = 100;
        int score = 0;

        Console.WriteLine("Welcome to the spaceship game!");
        Console.WriteLine("Commands: 'w' to move forward, 's' to move backward, 'a' to move left, 'd' to move right, 'q' to quit");

        while (true)
        {
            Console.WriteLine($"Fuel: {fuel} | Health: {health} | Score: {score}");

            Console.Write("Enter a command: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (input == 'q')
            {
                Console.WriteLine("Game over!");
                break;
            }

            switch (input)
            {
                case 'w':
                    fuel -= 10;
                    score += 5;
                    break;
                case 's':
                    fuel -= 5;
                    score += 2;
                    break;
                case 'a':
                    fuel -= 5;
                    score += 3;
                    break;
                case 'd':
                    fuel -= 5;
                    score += 3;
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }

            if (fuel <= 0)
            {
                Console.WriteLine("You ran out of fuel! Game over!");
                break;
            }

            if (health <= 0)
            {
                Console.WriteLine("Your spaceship was destroyed! Game over!");
                break;
            }

            if (score >= 100)
            {
                Console.WriteLine("You reached the target score! You win!");
                break;
            }
        }
    }
}
