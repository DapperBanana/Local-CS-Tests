
using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class InventoryManagementSystem
{
    List<InventoryItem> inventory;

    public InventoryManagementSystem()
    {
        inventory = new List<InventoryItem>();
    }

    public void AddItem(string name, int quantity)
    {
        InventoryItem newItem = new InventoryItem
        {
            Name = name,
            Quantity = quantity
        };

        inventory.Add(newItem);
        Console.WriteLine($"Added {quantity} {name}(s) to inventory.");
    }

    public void RemoveItem(string name, int quantity)
    {
        InventoryItem item = inventory.Find(i => i.Name == name);

        if (item != null && item.Quantity >= quantity)
        {
            item.Quantity -= quantity;
            Console.WriteLine($"Removed {quantity} {name}(s) from inventory.");
        }
        else
        {
            Console.WriteLine($"Unable to remove {quantity} {name}(s) from inventory. Not enough stock available.");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Name}: {item.Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem inventorySystem = new InventoryManagementSystem();

        inventorySystem.AddItem("Apples", 10);
        inventorySystem.AddItem("Oranges", 15);
        inventorySystem.DisplayInventory();

        inventorySystem.RemoveItem("Apples", 5);
        inventorySystem.RemoveItem("Oranges", 20);
        inventorySystem.DisplayInventory();
    }
}
