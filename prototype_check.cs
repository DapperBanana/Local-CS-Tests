
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Explorer!");
        Console.WriteLine("You are about to embark on a journey through space.");

        // Random events
        Random rnd = new Random();

        bool exploredMars = false;
        bool discoveredAlien = false;

        while (!exploredMars || !discoveredAlien)
        {
            int eventChance = rnd.Next(1, 101);

            if (eventChance <= 50 && !exploredMars)
            {
                Console.WriteLine("You have arrived at Mars!");
                Console.WriteLine("Would you like to explore the surface? (yes/no)");
                string exploreMars = Console.ReadLine();

                if (exploreMars.ToLower() == "yes")
                {
                    Console.WriteLine("You have discovered traces of water on Mars!");
                    exploredMars = true;
                }
            }
            else if (eventChance <= 30 && !discoveredAlien)
            {
                Console.WriteLine("You have encountered an alien spaceship!");
                Console.WriteLine("Do you want to investigate? (yes/no)");
                string investigateAlien = Console.ReadLine();

                if (investigateAlien.ToLower() == "yes")
                {
                    Console.WriteLine("The alien offers to trade advanced technology with you!");
                    discoveredAlien = true;
                }
            }
            else
            {
                Console.WriteLine("You continue your journey through space...");
            }
        }

        Console.WriteLine("Congratulations! You have successfully completed your space exploration journey.");
    }
}
