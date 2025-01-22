
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
    private List<InventoryItem> inventory = new List<InventoryItem>();

    public void AddItem(string name, int quantity, double price)
    {
        InventoryItem newItem = new InventoryItem { Name = name, Quantity = quantity, Price = price };
        inventory.Add(newItem);
        Console.WriteLine($"Added {quantity} {name}(s) to inventory.");
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (InventoryItem item in inventory)
        {
            Console.WriteLine($"{item.Name} - Quantity: {item.Quantity}, Price: ${item.Price}");
        }
    }

    public void UpdateItemQuantity(string name, int quantity)
    {
        foreach (InventoryItem item in inventory)
        {
            if (item.Name == name)
            {
                item.Quantity += quantity;
                Console.WriteLine($"Updated quantity of {name} to {item.Quantity}.");
                return;
            }
        }
        Console.WriteLine($"Item {name} not found in inventory.");
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem inventorySystem = new InventoryManagementSystem();

        inventorySystem.AddItem("Apple", 10, 1.50);
        inventorySystem.AddItem("Banana", 15, 0.75);
        inventorySystem.AddItem("Orange", 8, 1.00);

        inventorySystem.DisplayInventory();

        inventorySystem.UpdateItemQuantity("Apple", -5);
        inventorySystem.UpdateItemQuantity("Grape", 5);

        inventorySystem.DisplayInventory();
    }
}
