
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
        InventoryItem item = inventory.Find(i => i.Name == name);
        if (item != null)
        {
            item.Quantity += quantity;
        }
        else
        {
            inventory.Add(new InventoryItem(name, quantity));
        }
        Console.WriteLine($"Added {quantity} {name}(s) to inventory.");
    }

    public void RemoveItem(string name, int quantity)
    {
        InventoryItem item = inventory.Find(i => i.Name == name);
        if (item != null)
        {
            if (item.Quantity >= quantity)
            {
                item.Quantity -= quantity;
                Console.WriteLine($"Removed {quantity} {name}(s) from inventory.");
            }
            else
            {
                Console.WriteLine($"Not enough {name}(s) in inventory to remove.");
            }
        }
        else
        {
            Console.WriteLine($"Item {name} not found in inventory.");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Quantity} {item.Name}(s)");
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem inventorySystem = new InventoryManagementSystem();

        inventorySystem.AddItem("Pencil", 50);
        inventorySystem.AddItem("Notebook", 20);
        inventorySystem.DisplayInventory();

        inventorySystem.RemoveItem("Pencil", 10);
        inventorySystem.RemoveItem("Eraser", 5);
        inventorySystem.DisplayInventory();
    }
}
