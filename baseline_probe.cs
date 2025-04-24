
using System;

class VirtualPet
{
    private string name;
    private int hunger;
    private int boredom;

    // Constructor
    public VirtualPet(string name)
    {
        this.name = name;
        hunger = 0;
        boredom = 0;
    }

    // Public methods
    public void Feed()
    {
        hunger -= 2;
    }

    public void Play()
    {
        boredom -= 2;
    }

    public void Tick()
    {
        hunger++;
        boredom++;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Fluffy");

        while (true)
        {
            pet.Tick();
            pet.PrintStatus();

            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Do nothing");

            // User input
            string input = Console.ReadLine();

            if (input == "1")
            {
                pet.Feed();
            }
            else if (input == "2")
            {
                pet.Play();
            }
            else if (input == "3")
            {
                // Do nothing
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
