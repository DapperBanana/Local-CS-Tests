
using System;
using System.Threading;

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
        Console.WriteLine("You feed " + name + ". Hunger decreases by 10.");
    }

    public void Play()
    {
        happiness += 10;
        Console.WriteLine("You play with " + name + ". Happiness increases by 10.");
    }

    public void Status()
    {
        Console.WriteLine(name + " - Hunger: " + hunger + " Happiness: " + happiness);
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Fluffy");

        Console.WriteLine("Welcome to the Virtual Pet game!");

        while (true)
        {
            pet.Status();

            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    pet.Feed();
                    break;
                case "2":
                    pet.Play();
                    break;
                case "3":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Thread.Sleep(1000); // 1 second delay before showing pet's status again
        }
    }
}
