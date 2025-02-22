
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
        hunger -= 20;
        Console.WriteLine("You feed " + name);
    }

    public void Play()
    {
        happiness += 20;
        Console.WriteLine("You play with " + name);
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
        VirtualPet myPet = new VirtualPet("Fluffy");

        Console.WriteLine("Welcome to Virtual Pet Simulator");
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Quit");
            Console.WriteLine("Choose an action:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    myPet.Feed();
                    break;
                case 2:
                    myPet.Play();
                    break;
                case 3:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            myPet.Status();
        }
    }
}
