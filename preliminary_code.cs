
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
        happiness += 5;
        Console.WriteLine($"{name} has been fed and is now happier!");
    }

    public void Play()
    {
        hunger += 5;
        happiness += 10;
        Console.WriteLine($"{name} is having fun playing!");
    }

    public void GetStatus()
    {
        Console.WriteLine($"{name} - Hunger: {hunger}, Happiness: {happiness}");
    }
}

class Program
{
    static void Main()
    {
        VirtualPet myPet = new VirtualPet("Fluffy");
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Feed Pet");
            Console.WriteLine("2. Play with Pet");
            Console.WriteLine("3. Get Pet's Status");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an option: ");
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
                    myPet.GetStatus();
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
