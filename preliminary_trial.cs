
using System;

namespace VirtualPet
{
    class VirtualPet
    {
        static void Main(string[] args)
        {
            string name;
            int hunger = 0;
            int happiness = 10;

            Console.WriteLine("Welcome to Virtual Pet!");

            Console.Write("Enter the name of your pet: ");
            name = Console.ReadLine();

            Console.WriteLine("You now have a pet named " + name);

            bool quit = false;

            while (!quit)
            {
                Console.WriteLine("Here is the status of " + name + ":");
                Console.WriteLine("Hunger: " + hunger);
                Console.WriteLine("Happiness: " + happiness);

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Feed " + name);
                Console.WriteLine("2. Play with " + name);
                Console.WriteLine("3. Quit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        hunger--;
                        Console.WriteLine(name + " has eaten and is less hungry now.");
                        break;
                    case 2:
                        happiness++;
                        Console.WriteLine(name + " played and is happier now.");
                        break;
                    case 3:
                        quit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                // Update pet's status
                hunger++;
                happiness--;

                // Check if pet is too hungry or too unhappy
                if (hunger >= 10 || happiness <= 0)
                {
                    Console.WriteLine(name + " is not feeling well. Game over!");
                    quit = true;
                }
            }
        }
    }
}
