
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
        Console.WriteLine($"{name} has been fed.");
    }

    public void Play()
    {
        happiness += 10;
        Console.WriteLine($"{name} is happy after playing.");
    }

    public void CheckStatus()
    {
        Console.WriteLine($"{name}'s hunger level is {hunger}");
        Console.WriteLine($"{name}'s happiness level is {happiness}");
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Fluffy");

        bool gameRunning = true;
        while (gameRunning)
        {
            Console.WriteLine("1. Feed pet");
            Console.WriteLine("2. Play with pet");
            Console.WriteLine("3. Check pet's status");
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
                    pet.CheckStatus();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    gameRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
