
using System;

class VirtualPet
{
    private string name;
    private int hungry;
    private int happy;

    public VirtualPet(string name)
    {
        this.name = name;
        this.hungry = 0;
        this.happy = 100;
    }

    public void Feed()
    {
        hungry -= 20;
    }

    public void Play()
    {
        happy += 10;
    }

    public void DisplayStats()
    {
        Console.WriteLine("Pet: " + name);
        Console.WriteLine("Hungry: " + hungry);
        Console.WriteLine("Happy: " + happy);
    }
}

class Program
{
    static void Main()
    {
        VirtualPet pet = new VirtualPet("Fluffy");

        Console.WriteLine("Welcome to Virtual Pet Simulator!");
        pet.DisplayStats();

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Feed Pet");
            Console.WriteLine("2. Play with Pet");
            Console.WriteLine("3. Quit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                pet.Feed();
            }
            else if (input == "2")
            {
                pet.Play();
            }
            else if (input == "3")
            {
                break;
            }

            pet.DisplayStats();
        }
    }
}
