
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

    public void UpdateQuantity(int quantity)
    {
        Quantity += quantity;
    }
}

class Inventory
{
    private List<InventoryItem> items;

    public Inventory()
    {
        items = new List<InventoryItem>();
    }

    public void AddItem(string name, int quantity)
    {
        var existingItem = items.Find(item => item.Name == name);

        if (existingItem != null)
        {
            existingItem.UpdateQuantity(quantity);
        }
        else
        {
            items.Add(new InventoryItem(name, quantity));
        }

        Console.WriteLine($"Added {quantity} {name} to inventory.");
    }

    public void RemoveItem(string name, int quantity)
    {
        var existingItem = items.Find(item => item.Name == name);

        if (existingItem != null)
        {
            if (existingItem.Quantity >= quantity)
            {
                existingItem.UpdateQuantity(-quantity);
                Console.WriteLine($"Removed {quantity} {name} from inventory.");
            }
            else
            {
                Console.WriteLine($"Not enough {name} in inventory to remove.");
            }
        }
        else
        {
            Console.WriteLine($"{name} not found in inventory.");
        }
    }

    public void DisplayInventory()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name}: {item.Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddItem("Apple", 10);
        inventory.AddItem("Apple", 5);
        inventory.AddItem("Banana", 15);
        inventory.RemoveItem("Apple", 3);
        inventory.RemoveItem("Banana", 20);
        inventory.DisplayInventory();
    }
}
