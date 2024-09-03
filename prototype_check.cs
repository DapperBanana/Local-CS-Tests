
using System;
using System.Collections.Generic;

class InventoryItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class InventoryManagementSystem
{
    List<InventoryItem> inventory = new List<InventoryItem>();

    public void AddItem(InventoryItem item)
    {
        inventory.Add(item);
    }

    public void RemoveItem(int id)
    {
        InventoryItem item = inventory.Find(x => x.Id == id);
        if(item != null)
        {
            inventory.Remove(item);
            Console.WriteLine("Item removed successfully.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    public void UpdateItem(int id, int quantity)
    {
        InventoryItem item = inventory.Find(x => x.Id == id);
        if(item != null)
        {
            item.Quantity = quantity;
            Console.WriteLine("Item quantity updated successfully.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach(var item in inventory)
        {
            Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Quantity: {item.Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        InventoryItem item1 = new InventoryItem { Id = 1, Name = "Item1", Quantity = 10 };
        InventoryItem item2 = new InventoryItem { Id = 2, Name = "Item2", Quantity = 5 };

        ims.AddItem(item1);
        ims.AddItem(item2);

        ims.DisplayInventory();

        ims.RemoveItem(1);

        ims.DisplayInventory();

        ims.UpdateItem(2, 7);

        ims.DisplayInventory();
    }
}
