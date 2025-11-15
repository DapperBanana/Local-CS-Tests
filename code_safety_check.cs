
using System;
using System.Collections.Generic;

class InventoryManagementSystem
{
    Dictionary<string, int> inventory;

    public InventoryManagementSystem()
    {
        inventory = new Dictionary<string, int>();
    }

    public void AddItem(string item, int quantity)
    {
        if (inventory.ContainsKey(item))
        {
            inventory[item] += quantity;
        }
        else
        {
            inventory.Add(item, quantity);
        }
    }

    public void RemoveItem(string item, int quantity)
    {
        if (inventory.ContainsKey(item))
        {
            inventory[item] -= quantity;
            if (inventory[item] <= 0)
            {
                inventory.Remove(item);
            }
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (KeyValuePair<string, int> item in inventory)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        ims.AddItem("Apple", 10);
        ims.AddItem("Banana", 5);
        ims.AddItem("Orange", 8);

        ims.DisplayInventory();

        ims.RemoveItem("Banana", 2);

        ims.DisplayInventory();
    }
}
