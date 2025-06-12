
using System;

namespace TextBasedSpaceshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the text-based spaceship game!");
            Console.WriteLine("You are the captain of a spaceship on a mission to explore a distant planet.");
            Console.WriteLine("You need to navigate through asteroid fields and enemy spaceships to reach your destination.");

            int health = 100;
            int distanceTraveled = 0;
            Random rand = new Random();

            while (health > 0)
            {
                Console.WriteLine("Health: " + health);
                Console.WriteLine("Distance Traveled: " + distanceTraveled + " light years");

                Console.WriteLine("1. Continue on course");
                Console.WriteLine("2. Dodge asteroid field");
                Console.WriteLine("3. Engage enemy spaceship");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    int distance = rand.Next(1, 10);
                    distanceTraveled += distance;
                    Console.WriteLine("You traveled " + distance + " light years.");
                }
                else if (choice == 2)
                {
                    int damage = rand.Next(10, 20);
                    health -= damage;
                    Console.WriteLine("You hit an asteroid field and took " + damage + " damage.");
                }
                else if (choice == 3)
                {
                    int damage = rand.Next(20, 30);
                    health -= damage;
                    Console.WriteLine("You engaged an enemy spaceship and took " + damage + " damage.");
                }

                if (health <= 0)
                {
                    Console.WriteLine("Your spaceship was destroyed. Game Over.");
                }
            }
        }
    }
}
