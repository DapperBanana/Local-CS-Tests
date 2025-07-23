
using System;
using System.Collections.Generic;

class InventoryManagementSystem
{
    static Dictionary<string, int> inventory = new Dictionary<string, int>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Remove item from inventory");
            Console.WriteLine("3. View inventory");
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
                    ViewInventory();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddItem()
    {
        Console.WriteLine("Enter item name:");
        string item = Console.ReadLine();

        Console.WriteLine("Enter item quantity:");
        int quantity = int.Parse(Console.ReadLine());

        if (inventory.ContainsKey(item))
        {
            inventory[item] += quantity;
        }
        else
        {
            inventory.Add(item, quantity);
        }

        Console.WriteLine("Item added to inventory.");
    }

    static void RemoveItem()
    {
        Console.WriteLine("Enter item name to remove:");
        string item = Console.ReadLine();

        if (inventory.ContainsKey(item))
        {
            inventory.Remove(item);
            Console.WriteLine("Item removed from inventory.");
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
        }
    }

    static void ViewInventory()
    {
        Console.WriteLine("Inventory:");
        
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
