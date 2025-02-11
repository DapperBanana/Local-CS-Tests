
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
        inventory.Add(new InventoryItem { Name = name, Quantity = quantity });
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Name}: {item.Quantity}");
        }
    }

    public void UpdateQuantity(string name, int quantity)
    {
        foreach (var item in inventory)
        {
            if (item.Name == name)
            {
                item.Quantity = quantity;
                return;
            }
        }
        Console.WriteLine($"Item '{name}' not found in inventory.");
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        ims.AddItem("Apple", 10);
        ims.AddItem("Banana", 20);
        ims.AddItem("Orange", 15);

        ims.DisplayInventory();

        ims.UpdateQuantity("Banana", 30);

        ims.DisplayInventory();
    }
}
