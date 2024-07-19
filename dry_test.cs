
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
        Console.WriteLine("Item added to inventory.");
    }

    public void RemoveItem(string name)
    {
        var item = inventory.Find(i => i.Name == name);
        
        if (item != null)
        {
            inventory.Remove(item);
            Console.WriteLine("Item removed from inventory.");
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        ims.AddItem("Apple", 10);
        ims.AddItem("Banana", 5);
        ims.AddItem("Orange", 8);

        ims.DisplayInventory();

        ims.RemoveItem("Banana");

        ims.DisplayInventory();
    }
}
