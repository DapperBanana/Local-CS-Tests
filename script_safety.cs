
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
        InventoryItem newItem = new InventoryItem { Name = name, Quantity = quantity };
        inventory.Add(newItem);
        Console.WriteLine($"Added item: {name} Quantity: {quantity}");
    }

    public void RemoveItem(string name)
    {
        InventoryItem itemToRemove = inventory.Find(item => item.Name == name);

        if (itemToRemove != null)
        {
            inventory.Remove(itemToRemove);
            Console.WriteLine($"Removed item: {name}");
        }
        else
        {
            Console.WriteLine($"Item {name} not found.");
        }
    }

    public void DisplayInventory()
    {
        foreach (InventoryItem item in inventory)
        {
            Console.WriteLine($"Item: {item.Name}, Quantity: {item.Quantity}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        ims.AddItem("Apple", 10);
        ims.AddItem("Banana", 15);

        ims.DisplayInventory();

        ims.RemoveItem("Apple");

        ims.DisplayInventory();
    }
}
