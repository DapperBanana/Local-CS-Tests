
using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

class Program
{
    static List<InventoryItem> inventory = new List<InventoryItem>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Display inventory");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddItemToInventory();
                    break;
                case 2:
                    DisplayInventory();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddItemToInventory()
    {
        InventoryItem item = new InventoryItem();

        Console.Write("Enter item name: ");
        item.Name = Console.ReadLine();

        Console.Write("Enter item quantity: ");
        item.Quantity = int.Parse(Console.ReadLine());

        Console.Write("Enter item price: ");
        item.Price = double.Parse(Console.ReadLine());

        inventory.Add(item);

        Console.WriteLine("Item added to inventory.");
        Console.WriteLine();
    }

    static void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (InventoryItem item in inventory)
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price}");
        }
        Console.WriteLine();
    }
}
