
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> inventory = new Dictionary<string, int>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Remove item from inventory");
            Console.WriteLine("3. Display inventory");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

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
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddItem()
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        if (inventory.ContainsKey(itemName))
        {
            Console.WriteLine("Item already exists in inventory. Updating quantity.");
            Console.Write("Enter quantity to add: ");
            int quantity = int.Parse(Console.ReadLine());
            inventory[itemName] += quantity;
        }
        else
        {
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            inventory.Add(itemName, quantity);
        }

        Console.WriteLine("Item added successfully.");
    }

    static void RemoveItem()
    {
        Console.Write("Enter item name to remove: ");
        string itemName = Console.ReadLine();

        if (inventory.ContainsKey(itemName))
        {
            inventory.Remove(itemName);
            Console.WriteLine("Item removed successfully.");
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
        }
    }

    static void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
