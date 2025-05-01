
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
    private List<InventoryItem> inventory;

    public InventoryManagementSystem()
    {
        inventory = new List<InventoryItem>();
    }

    public void AddItem(string name, int quantity, double price)
    {
        InventoryItem newItem = new InventoryItem { Name = name, Quantity = quantity, Price = price };
        inventory.Add(newItem);
        Console.WriteLine($"Added item: {name}");
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
            Console.WriteLine($"Item {name} not found in inventory");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (InventoryItem item in inventory)
        {
            Console.WriteLine($"Name: {item.Name} - Quantity: {item.Quantity} - Price: {item.Price}");
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        ims.AddItem("Apple", 10, 1.50);
        ims.AddItem("Banana", 20, 0.75);
        ims.AddItem("Orange", 15, 2.00);

        ims.DisplayInventory();

        ims.RemoveItem("Banana");

        ims.DisplayInventory();
    }
}
