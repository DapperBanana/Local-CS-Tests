
using System;

class VirtualPet
{
    private string name;
    private int hunger;
    private int happiness;

    public VirtualPet(string name)
    {
        this.name = name;
        hunger = 50;
        happiness = 50;
    }

    public void Feed()
    {
        hunger -= 10;
        Console.WriteLine(name + " has been fed.");
    }

    public void Play()
    {
        happiness += 10;
        Console.WriteLine(name + " is happy!");
    }

    public void CheckStatus()
    {
        Console.WriteLine("--------");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Hunger: " + hunger);
        Console.WriteLine("Happiness: " + happiness);
        Console.WriteLine("--------");
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Fluffy");

        bool exit = false;

        Console.WriteLine("Welcome to Virtual Pet!");

        while (!exit)
        {
            pet.CheckStatus();

            Console.WriteLine("1. Feed " + pet.name);
            Console.WriteLine("2. Play with " + pet.name);
            Console.WriteLine("3. Exit");

            Console.WriteLine("Choose an option:");
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
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
