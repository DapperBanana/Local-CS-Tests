
using System;

class Program
{
    static void Main()
    {
        int cars = 0;
        int tick = 0;

        while (true)
        {
            Console.WriteLine("Tick: " + tick);
            Console.WriteLine("There are currently " + cars + " cars on the road.");

            string input = Console.ReadLine();

            if (input == "add")
            {
                cars++;
                Console.WriteLine("Added a car to the road.");
            }
            else if (input == "remove")
            {
                if (cars > 0)
                {
                    cars--;
                    Console.WriteLine("Removed a car from the road.");
                }
                else
                {
                    Console.WriteLine("There are no cars on the road to remove.");
                }
            }
            else if (input == "exit")
            {
                Console.WriteLine("Exiting traffic simulation program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please type 'add' to add a car, 'remove' to remove a car, or 'exit' to exit the program.");
            }

            tick++;
            Console.WriteLine();
        }
    }
}
