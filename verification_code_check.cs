
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
        Console.WriteLine($"{Name} has been fed.");
    }

    public void Play()
    {
        Happiness += 10;
        Console.WriteLine($"{Name} is happy!");
    }

    public void PrintStatus()
    {
        Console.WriteLine($"{Name}'s Hunger: {Hunger}");
        Console.WriteLine($"{Name}'s Happiness: {Happiness}");
    }
}

class Program
{
    static void Main()
    {
        VirtualPet myPet = new VirtualPet("Fluffy");

        Console.WriteLine("Welcome to Virtual Pet!");
        Console.WriteLine("Type 'feed' to feed your pet or 'play' to play with your pet.");

        while (true)
        {
            myPet.PrintStatus();

            string input = Console.ReadLine();

            if (input == "feed")
            {
                myPet.Feed();
            }
            else if (input == "play")
            {
                myPet.Play();
            }
            else
            {
                Console.WriteLine("Invalid command. Please type 'feed' or 'play'.");
            }
        }
    }
}
