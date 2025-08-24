
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

class InventoryManagementSystem
{
    private List<InventoryItem> inventory = new List<InventoryItem>();

    public void AddItem(string name, int quantity)
    {
        inventory.Add(new InventoryItem(name, quantity));
        Console.WriteLine($"Added {quantity} {name}(s) to inventory.");
    }

    public void RemoveItem(string name, int quantity)
    {
        InventoryItem item = inventory.Find(it => it.Name == name);

        if (item != null)
        {
            if (item.Quantity >= quantity)
            {
                item.Quantity -= quantity;
                Console.WriteLine($"Removed {quantity} {name}(s) from inventory.");
            }
            else
            {
                Console.WriteLine($"Not enough {name}(s) in inventory.");
            }
        }
        else
        {
            Console.WriteLine($"{name} not found in inventory.");
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
    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        ims.AddItem("Apple", 10);
        ims.AddItem("Banana", 15);
        ims.AddItem("Orange", 20);

        ims.DisplayInventory();

        ims.RemoveItem("Apple", 5);
        ims.RemoveItem("Banana", 10);
        ims.RemoveItem("Grapes", 5);

        ims.DisplayInventory();
    }
}
