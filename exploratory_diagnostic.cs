
using System;

class VirtualPet
{
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }

    public VirtualPet(string name)
    {
        Name = name;
        Hunger = 50;
        Happiness = 50;
    }

    public void Feed()
    {
        Hunger -= 10;
        Console.WriteLine("You feed " + Name + ".");
    }

    public void Play()
    {
        Happiness += 10;
        Console.WriteLine("You play with " + Name + ".");
    }

    public void Tick()
    {
        Hunger += 5;
        Happiness -= 5;
    }

    public void PrintStatus()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Hunger: " + Hunger);
        Console.WriteLine("Happiness: " + Happiness);
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Max");

        Console.WriteLine("Welcome to the virtual pet simulator!");
        Console.WriteLine("Type 'feed' to feed your pet, 'play' to play with your pet, or 'quit' to exit.");

        while (true)
        {
            pet.Tick();
            pet.PrintStatus();

            Console.Write("Enter a command: ");
            string input = Console.ReadLine();

            if (input == "feed")
            {
                pet.Feed();
            }
            else if (input == "play")
            {
                pet.Play();
            }
            else if (input == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Try again.");
            }
            Console.WriteLine();
        }
    }
}
