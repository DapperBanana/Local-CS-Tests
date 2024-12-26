
using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

class InventoryManagementSystem
{
    private List<InventoryItem> inventory = new List<InventoryItem>();

    private void AddItem()
    {
        Console.WriteLine("Enter item name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter item quantity:");
        int quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter item price:");
        double price = double.Parse(Console.ReadLine());

        InventoryItem newItem = new InventoryItem
        {
            Name = name,
            Quantity = quantity,
            Price = price
        };

        inventory.Add(newItem);
    }

    private void DisplayInventory()
    {
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Name} - Quantity: {item.Quantity}, Price: ${item.Price}");
        }
    }

    public void Run()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Display Inventory");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Select option:");

            int choice = int.Parse(Console.ReadLine());

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
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();
        ims.Run();
    }
}
