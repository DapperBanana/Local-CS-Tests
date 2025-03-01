
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

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Remove item from inventory");
            Console.WriteLine("3. Display inventory");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddItemToInventory();
                    break;
                case 2:
                    RemoveItemFromInventory();
                    break;
                case 3:
                    DisplayInventory();
                    break;
                case 4:
                    running = false;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddItemToInventory()
    {
        Console.WriteLine("Enter the name of the item:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the quantity of the item:");
        int quantity = int.Parse(Console.ReadLine());

        InventoryItem newItem = new InventoryItem { Name = name, Quantity = quantity };
        inventory.Add(newItem);

        Console.WriteLine("Item added to inventory.");
    }

    static void RemoveItemFromInventory()
    {
        Console.WriteLine("Enter the name of the item you want to remove:");
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
        if (inventory.Count > 0)
        {
            Console.WriteLine("Inventory items:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}");
            }
        }
        else
        {
            Console.WriteLine("Inventory is currently empty.");
        }
    }
}
