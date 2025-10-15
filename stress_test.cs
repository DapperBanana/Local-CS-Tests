
using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class InventoryManagementSystem
{
    private List<InventoryItem> inventory = new List<InventoryItem>();

    public void AddItem(string name, int quantity)
    {
        InventoryItem newItem = new InventoryItem { Name = name, Quantity = quantity };
        inventory.Add(newItem);
        Console.WriteLine($"Added {quantity} {name} to inventory.");
    }

    public void RemoveItem(string name, int quantity)
    {
        InventoryItem item = inventory.Find(i => i.Name == name);
        if (item != null)
        {
            if (item.Quantity >= quantity)
            {
                item.Quantity -= quantity;
                Console.WriteLine($"Removed {quantity} {name} from inventory.");
            }
            else
            {
                Console.WriteLine($"Not enough {name} in inventory.");
            }
        }
        else
        {
            Console.WriteLine($"Item {name} not found in inventory.");
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
        InventoryManagementSystem inventorySystem = new InventoryManagementSystem();

        inventorySystem.AddItem("Apples", 10);
        inventorySystem.AddItem("Bananas", 15);

        inventorySystem.DisplayInventory();

        inventorySystem.RemoveItem("Apples", 5);
        inventorySystem.RemoveItem("Oranges", 3);

        inventorySystem.DisplayInventory();
    }
}
