
using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public InventoryItem(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}

class Program
{
    static List<InventoryItem> inventory = new List<InventoryItem>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. Add item\n2. Remove item\n3. View inventory\n4. Exit");
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
        Console.Write("Enter the name of the item: ");
        string name = Console.ReadLine();
        Console.Write("Enter the quantity of the item: ");
        int quantity = int.Parse(Console.ReadLine());

        InventoryItem item = new InventoryItem(name, quantity);
        inventory.Add(item);

        Console.WriteLine("Item added to inventory.");
    }

    static void RemoveItem()
    {
        Console.Write("Enter the name of the item to remove: ");
        string name = Console.ReadLine();

        InventoryItem item = inventory.Find(x => x.Name == name);
        if (item != null)
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
        Console.WriteLine("Current Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Name}: {item.Quantity}");
        }
    }
}
