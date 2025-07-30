
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
        hunger -= 10;
        if (hunger < 0)
        {
            hunger = 0;
        }
        happiness += 5;
        if (happiness > 100)
        {
            happiness = 100;
        }
        Console.WriteLine($"{name} has been fed.");
    }

    public void Play()
    {
        hunger += 5;
        if (hunger > 100)
        {
            hunger = 100;
        }
        happiness += 10;
        if (happiness > 100)
        {
            happiness = 100;
        }
        Console.WriteLine($"{name} has played with you.");
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Happiness: {happiness}");
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Fluffy");

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Display Stats");
            Console.WriteLine("4. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    pet.Feed();
                    break;
                case 2:
                    pet.Play();
                    break;
                case 3:
                    pet.DisplayStats();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
