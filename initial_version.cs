
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
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddItem()
    {
        Console.WriteLine("Enter item name:");
        string itemName = Console.ReadLine();
        
        Console.WriteLine("Enter quantity:");
        int quantity = int.Parse(Console.ReadLine());

        if (inventory.ContainsKey(itemName))
        {
            inventory[itemName] += quantity;
        }
        else
        {
            inventory[itemName] = quantity;
        }

        Console.WriteLine($"Added {quantity} {itemName}(s) to inventory.");
    }

    static void RemoveItem()
    {
        Console.WriteLine("Enter item name:");
        string itemName = Console.ReadLine();
        
        if (inventory.ContainsKey(itemName))
        {
            Console.WriteLine("Enter quantity to remove:");
            int quantity = int.Parse(Console.ReadLine());

            if (inventory[itemName] >= quantity)
            {
                inventory[itemName] -= quantity;
                Console.WriteLine($"Removed {quantity} {itemName}(s) from inventory.");
            }
            else
            {
                Console.WriteLine("Insufficient quantity in inventory.");
            }
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
