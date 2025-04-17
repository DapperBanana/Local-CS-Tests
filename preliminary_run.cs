
using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static List<InventoryItem> inventory = new List<InventoryItem>();

    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Remove item from inventory");
            Console.WriteLine("3. Display inventory");
            Console.WriteLine("4. Exit");

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
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddItem()
    {
        Console.Write("Enter the name of the item: ");
        string name = Console.ReadLine();

        Console.Write("Enter the quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        InventoryItem item = new InventoryItem { Name = name, Quantity = quantity };
        inventory.Add(item);

        Console.WriteLine("Item added to inventory.");
    }

    static void RemoveItem()
    {
        Console.Write("Enter the name of the item to remove: ");
        string name = Console.ReadLine();

        InventoryItem itemToRemove = inventory.Find(item => item.Name == name);

        if (itemToRemove != null)
        {
            inventory.Remove(itemToRemove);
            Console.WriteLine("Item removed from inventory.");
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
            Console.WriteLine($"{item.Name}: {item.Quantity}");
        }
    }
}
