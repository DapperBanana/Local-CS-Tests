
using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class InventoryManagementSystem
{
    private List<InventoryItem> inventory;

    public InventoryManagementSystem()
    {
        inventory = new List<InventoryItem>();
    }

    public void AddItem(string name, int quantity)
    {
        InventoryItem newItem = new InventoryItem() { Name = name, Quantity = quantity };
        inventory.Add(newItem);
        Console.WriteLine($"Added {quantity} {name}(s) to inventory.");
    }

    public void RemoveItem(string name, int quantity)
    {
        InventoryItem item = inventory.Find(x => x.Name == name);
        if (item != null)
        {
            if (item.Quantity >= quantity)
            {
                item.Quantity -= quantity;
                Console.WriteLine($"Removed {quantity} {name}(s) from inventory.");
            }
            else
            {
                Console.WriteLine($"Error: Not enough {name} in inventory.");
            }
        }
        else
        {
            Console.WriteLine($"Error: {name} not found in inventory.");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (InventoryItem item in inventory)
        {
            Console.WriteLine($"{item.Name}: {item.Quantity}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        ims.AddItem("Apple", 10);
        ims.AddItem("Banana", 5);

        ims.DisplayInventory();

        ims.RemoveItem("Apple", 3);

        ims.DisplayInventory();
    }
}
