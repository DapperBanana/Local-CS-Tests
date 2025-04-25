
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

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Remove item from inventory");
            Console.WriteLine("3. View inventory");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

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
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void AddItem()
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();
        Console.Write("Enter quantity: ");
        int itemQuantity = Convert.ToInt32(Console.ReadLine());

        InventoryItem newItem = new InventoryItem(itemName, itemQuantity);
        inventory.Add(newItem);

        Console.WriteLine("Item added to inventory.");
    }

    static void RemoveItem()
    {
        Console.Write("Enter item name to remove: ");
        string itemName = Console.ReadLine();

        InventoryItem itemToRemove = inventory.Find(item => item.Name == itemName);
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

    static void ViewInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (InventoryItem item in inventory)
        {
            Console.WriteLine($"{item.Name} - Quantity: {item.Quantity}");
        }
    }
}
