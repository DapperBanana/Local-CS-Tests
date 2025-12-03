using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet pet = new VirtualPet("Buddy");
            Console.WriteLine($"Welcome to the Virtual Pet Simulator! You got a new pet named {pet.Name}.");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Check Status");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        pet.Feed();
                        break;
                    case "2":
                        pet.Play();
                        break;
                    case "3":
                        pet.Rest();
                        break;
                    case "4":
                        pet.DisplayStatus();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Goodbye! Thanks for taking care of your pet.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number from 1 to 5.");
                        break;
                }

                if (!exit)
                {
                    pet.PassTime();
                }
            }
        }
    }

    class VirtualPet
    {
        public string Name { get; private set; }
        private int Hunger;        // 0 (full) to 10 (starving)
        private int Boredom;       // 0 (happy) to 10 (bored)
        private int Energy;        // 0 (rested) to 10 (tired)

        private static Random rand = new Random();

        public VirtualPet(string name)
        {
            Name = name;
            Hunger = 0;
            Boredom = 0;
            Energy = 0;
        }

        public void Feed()
        {
            Hunger = Math.Max(Hunger - 3, 0);
            Console.WriteLine($"{Name} has been fed. Hunger is now {Hunger}.");
        }

        public void Play()
        {
            if (Energy >= 2)
            {
                Boredom = Math.Max(Boredom - 4, 0);
                Energy = Math.Min(Energy + 2, 10);
                Console.WriteLine($"{Name} played happily! Boredom is now {Boredom}. Energy increased to {Energy}.");
            }
            else
            {
                Console.WriteLine($"{Name} is too tired to play. Let them rest first.");
            }
        }

        public void Rest()
        {
            Energy = Math.Max(Energy - 3, 0);
            Console.WriteLine($"{Name} is resting. Energy is now {Energy}.");
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"\n{Name}'s Status:");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Boredom: {Boredom}");
            Console.WriteLine($"Energy: {Energy}");
        }

        public void PassTime()
        {
            Hunger = Math.Min(Hunger + rand.Next(1, 3), 10);
            Boredom = Math.Min(Boredom + rand.Next(1, 3), 10);
            Energy = Math.Min(Energy + rand.Next(0, 2), 10);

            // Check if pet is in bad condition
            if (Hunger >= 8)
            {
                Console.WriteLine($"{Name} is very hungry!");
            }
            if (Boredom >= 8)
            {
                Console.WriteLine($"{Name} is very bored!");
            }
            if (Energy >= 8)
            {
                Console.WriteLine($"{Name} is very tired!");
            }
        }
    }
}