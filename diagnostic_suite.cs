
using System;
using System.Collections.Generic;

class Inventory
{
    private Dictionary<string, int> items;

    public Inventory()
    {
        items = new Dictionary<string, int>();
    }

    public void AddItem(string itemName, int quantity)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] += quantity;
        }
        else
        {
            items.Add(itemName, quantity);
        }
    }

    public void RemoveItem(string itemName, int quantity)
    {
        if (items.ContainsKey(itemName))
        {
            if (items[itemName] >= quantity)
            {
                items[itemName] -= quantity;
                if (items[itemName] == 0)
                {
                    items.Remove(itemName);
                }
            }
            else
            {
                Console.WriteLine("Not enough quantity of {0} in inventory!", itemName);
            }
        }
        else
        {
            Console.WriteLine("{0} not found in inventory!", itemName);
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in items)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        inventory.AddItem("Apples", 10);
        inventory.AddItem("Bananas", 15);
        inventory.AddItem("Oranges", 20);

        inventory.DisplayInventory();

        inventory.RemoveItem("Apples", 5);
        inventory.RemoveItem("Grapes", 5);

        inventory.DisplayInventory();
    }
}
