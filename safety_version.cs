
using System;

class VirtualPet
{
    private string name;
    private int hunger;
    private int happiness;

    public VirtualPet(string name)
    {
        this.name = name;
        this.hunger = 0;
        this.happiness = 100;
    }

    public void Feed()
    {
        hunger -= 20;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Play()
    {
        happiness += 10;
        if (happiness > 100)
        {
            happiness = 100;
        }
        hunger += 10;
        if (hunger > 100)
        {
            hunger = 100;
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Hunger: {0}", hunger);
        Console.WriteLine("Happiness: {0}", happiness);
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Fluffy");

        while (true)
        {
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Quit");
            Console.WriteLine();
            pet.ShowStatus();

            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    pet.Feed();
                    break;
                case 2:
                    pet.Play();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
