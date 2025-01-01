
using System;
using System.Threading;

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
        Hunger -= 20;
        Happiness += 10;
    }

    public void Play()
    {
        Hunger += 10;
        Happiness += 20;
    }

    public void Tick()
    {
        Hunger += 5;
        Happiness -= 5;
    }

    public void CheckStatus()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Hunger: {Hunger}");
        Console.WriteLine($"Happiness: {Happiness}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Pet");

        bool exit = false;

        Console.WriteLine("Welcome to the Virtual Pet Simulator!");
        Console.WriteLine();

        while (!exit)
        {
            pet.Tick();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Check pet's status");
            Console.WriteLine("4. Exit");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    pet.Feed();
                    Console.WriteLine("You feed the pet");
                    break;
                case '2':
                    pet.Play();
                    Console.WriteLine("You play with the pet");
                    break;
                case '3':
                    pet.CheckStatus();
                    break;
                case '4':
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Thread.Sleep(1000);
            Console.Clear();
        }

        Console.WriteLine("Thank you for playing the Virtual Pet Simulator!");
    }
}
