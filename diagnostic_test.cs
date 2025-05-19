
using System;

class VirtualPet
{
    private string name;
    private int hunger;
    private int boredom;

    public VirtualPet(string name)
    {
        this.name = name;
        hunger = 0;
        boredom = 0;
    }

    public void Feed()
    {
        Console.WriteLine(name + " has been fed.");
        hunger -= 5;
    }

    public void Play()
    {
        Console.WriteLine(name + " is playing.");
        boredom -= 5;
    }

    public void Tick()
    {
        hunger++;
        boredom++;

        if (hunger >= 10 || boredom >= 10)
        {
            Console.WriteLine(name + " has run away due to neglect.");
            Environment.Exit(0);
        }
    }

    public void PrintStatus()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Hunger: " + hunger);
        Console.WriteLine("Boredom: " + boredom);
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Rover");

        while (true)
        {
            Console.WriteLine("1. Feed pet");
            Console.WriteLine("2. Play with pet");
            Console.WriteLine("3. Do nothing");
            Console.WriteLine("4. Quit");

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
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            pet.Tick();
            pet.PrintStatus();
        }
    }
}
