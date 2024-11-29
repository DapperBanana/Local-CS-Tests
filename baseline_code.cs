
using System;

class VirtualPet
{
    private string name;
    private int hunger;
    private int happiness;

    public VirtualPet(string name)
    {
        this.name = name;
        this.hunger = 50;
        this.happiness = 50;
    }

    public void Feed()
    {
        hunger -= 10;
        Console.WriteLine("You feed " + name);
    }

    public void Play()
    {
        happiness += 10;
        Console.WriteLine("You play with " + name);
    }

    public void Tick()
    {
        hunger += 5;
        happiness -= 5;
    }

    public void PrintStats()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Hunger: " + hunger);
        Console.WriteLine("Happiness: " + happiness);
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Fluffy");

        bool quit = false;

        while (!quit)
        {
            pet.Tick();
            pet.PrintStats();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Quit");

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
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
