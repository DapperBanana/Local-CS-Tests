
using System;
using System.Collections.Generic;

class InventoryManagementSystem
{
    static void Main()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();

        while (true)
        {
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Remove item from inventory");
            Console.WriteLine("3. View inventory");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
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

                    Console.WriteLine("Item added to inventory.");
                    break;

                case 2:
                    Console.Write("Enter item name to remove: ");
                    string itemToRemove = Console.ReadLine();

                    if (inventory.ContainsKey(itemToRemove))
                    {
                        inventory.Remove(itemToRemove);
                        Console.WriteLine("Item removed from inventory.");
                    }
                    else
                    {
                        Console.WriteLine("Item not found in inventory.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Inventory:");
                    foreach (var item in inventory)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting inventory management system.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
