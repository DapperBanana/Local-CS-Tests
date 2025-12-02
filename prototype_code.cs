using System;

class VirtualPet
{
    static string name;
    static int hunger = 50;
    static int happiness = 50;
    static int energy = 50;
    static bool isRunning = true;

    static void Main()
    {
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");
        Console.Write("Please name your pet: ");
        name = Console.ReadLine();

        while (isRunning)
        {
            ShowStatus();
            ShowMenu();
            HandleUserChoice();
            UpdatePetStatus();
        }

        Console.WriteLine("Thanks for playing! Your pet fought a good fight.");
    }

    static void ShowStatus()
    {
        Console.WriteLine($"\n--- {name}'s Status ---");
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Happiness: {happiness}");
        Console.WriteLine($"Energy: {energy}");
        Console.WriteLine("------------------------");
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("1. Feed");
        Console.WriteLine("2. Play");
        Console.WriteLine("3. Rest");
        Console.WriteLine("4. Quit");
        Console.Write("Enter your choice: ");
    }

    static void HandleUserChoice()
    {
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Feed();
                break;
            case "2":
                Play();
                break;
            case "3":
                Rest();
                break;
            case "4":
                isRunning = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Please select 1-4.");
                break;
        }
    }

    static void Feed()
    {
        Console.WriteLine($"Feeding {name}...");
        hunger -= 20;
        if (hunger < 0) hunger = 0;
        Console.WriteLine($"{name} is less hungry now.");
    }

    static void Play()
    {
        if (energy >= 10)
        {
            Console.WriteLine($"Playing with {name}...");
            happiness += 15;
            energy -= 10;
            hunger += 5; // Playing makes pet a bit hungrier
            if (happiness > 100) happiness = 100;
            Console.WriteLine($"{name} is happier now!");
        }
        else
        {
            Console.WriteLine($"{name} is too tired to play. Rest before playing again.");
        }
    }

    static void Rest()
    {
        Console.WriteLine($"{name} is resting...");
        energy += 20;
        hunger += 10; // Resting makes pet a bit hungrier
        if (energy > 100) energy = 100;
        Console.WriteLine($"{name} feels more energetic now.");
    }

    static void UpdatePetStatus()
    {
        // Over time, hunger and energy change
        hunger += 5;
        energy -= 5;

        if (hunger > 100) hunger = 100;
        if (energy < 0) energy = 0;

        CheckPetStatus();
    }

    static void CheckPetStatus()
    {
        if (hunger >= 100)
        {
            Console.WriteLine($"{name} is starving! Take better care of your pet.");
        }
        if (energy <= 0)
        {
            Console.WriteLine($"{name} is exhausted and needs rest!");
        }
        if (happiness <= 0)
        {
            Console.WriteLine($"{name} is very sad. Play with your pet to cheer it up!");
        }
    }
}