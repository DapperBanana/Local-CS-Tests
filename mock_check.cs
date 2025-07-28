
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
        InventoryItem item = new InventoryItem
        {
            Name = name,
            Quantity = quantity,
            Price = price
        };

        inventory.Add(item);

        Console.WriteLine($"{name} added to inventory.");
    }

    public void RemoveItem(string name)
    {
        InventoryItem itemToRemove = inventory.Find(i => i.Name == name);
        if (itemToRemove != null)
        {
            inventory.Remove(itemToRemove);
            Console.WriteLine($"{name} removed from inventory.");
        }
        else
        {
            Console.WriteLine($"{name} not found in inventory.");
        }
    }

    public void ListInventory()
    {
        Console.WriteLine("Current Inventory:");

        foreach (var item in inventory)
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}, Price: ${item.Price}");
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
        ims.AddItem("Orange", 15, 1.00);

        ims.ListInventory();

        ims.RemoveItem("Banana");

        ims.ListInventory();
    }
}
