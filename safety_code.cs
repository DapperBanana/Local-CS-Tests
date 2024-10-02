
using System;
using System.Collections.Generic;

class Program
{
    static List<string> inventory = new List<string>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nInventory Management System");
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. Display inventory");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    AddItem();
                    break;
                case 2:
                    RemoveItem();
                    break;
                case 3:
                    DisplayInventory();
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddItem()
    {
        Console.Write("Enter item to add: ");
        string item = Console.ReadLine();
        inventory.Add(item);
        Console.WriteLine("Item added to inventory.");
    }

    static void RemoveItem()
    {
        Console.Write("Enter item to remove: ");
        string item = Console.ReadLine();
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
            Console.WriteLine("Item removed from inventory.");
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
        }
    }

    static void DisplayInventory()
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
        }
        else
        {
            Console.WriteLine("Inventory:");
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
