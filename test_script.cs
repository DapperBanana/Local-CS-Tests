
using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class InventoryManager
{
    private List<InventoryItem> inventory = new List<InventoryItem>();

    public void AddItem(string name, int quantity)
    {
        inventory.Add(new InventoryItem { Name = name, Quantity = quantity });
        Console.WriteLine($"{name} added to inventory with quantity {quantity}");
    }

    public void RemoveItem(string name)
    {
        InventoryItem item = inventory.Find(x => x.Name == name);
        if (item != null)
        {
            inventory.Remove(item);
            Console.WriteLine($"{name} removed from inventory");
        }
        else
        {
            Console.WriteLine($"{name} not found in inventory");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
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
        InventoryManager manager = new InventoryManager();
        
        manager.AddItem("Apple", 10);
        manager.AddItem("Banana", 20);
        manager.DisplayInventory();
        
        manager.RemoveItem("Apple");
        manager.DisplayInventory();
    }
}
