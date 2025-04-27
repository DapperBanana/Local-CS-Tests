
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> inventory = new Dictionary<string, int>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Remove item from inventory");
            Console.WriteLine("3. View inventory");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddItemToInventory();
                    break;
                case 2:
                    RemoveItemFromInventory();
                    break;
                case 3:
                    ViewInventory();
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

    static void AddItemToInventory()
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        if (inventory.ContainsKey(itemName))
        {
            inventory[itemName] += quantity;
        }
        else
        {
            inventory[itemName] = quantity;
        }

        Console.WriteLine("Item added to inventory successfully.");
    }

    static void RemoveItemFromInventory()
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        if (inventory.ContainsKey(itemName))
        {
            Console.Write("Enter quantity to remove: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (inventory[itemName] > quantity)
            {
                inventory[itemName] -= quantity;
            }
            else
            {
                inventory.Remove(itemName);
            }

            Console.WriteLine("Item removed from inventory successfully.");
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
