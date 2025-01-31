
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
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Display inventory");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddItem();
                    break;
                case 2:
                    DisplayInventory();
                    break;
                case 3:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddItem()
    {
        InventoryItem item = new InventoryItem();

        Console.Write("Enter item name: ");
        item.Name = Console.ReadLine();

        Console.Write("Enter quantity: ");
        item.Quantity = Convert.ToInt32(Console.ReadLine());

        inventory.Add(item);

        Console.WriteLine("Item added to inventory");
    }

    static void DisplayInventory()
    {
        foreach (var item in inventory)
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}");
        }
    }
}
