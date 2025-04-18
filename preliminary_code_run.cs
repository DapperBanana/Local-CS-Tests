
using System;
using System.Collections.Generic;

class InventoryManagementSystem
{
    static Dictionary<string, int> inventory = new Dictionary<string, int>();

    static void Main()
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Remove item from inventory");
            Console.WriteLine("3. Display inventory");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice: ");
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
                    quit = true;
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

        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        if (inventory.ContainsKey(itemName))
        {
            inventory[itemName] += quantity;
        }
        else
        {
            inventory[itemName] = quantity;
        }
    }

    static void RemoveItem()
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        if (inventory.ContainsKey(itemName))
        {
            Console.Write("Enter quantity to remove: ");
            int quantity = int.Parse(Console.ReadLine());

            if (inventory[itemName] >= quantity)
            {
                inventory[itemName] -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough quantity in inventory.");
            }
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
        }
    }

    static void DisplayInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
