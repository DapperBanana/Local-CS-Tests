
using System;
using System.Collections.Generic;

class InventoryManagementSystem
{
    static Dictionary<string, int> inventory = new Dictionary<string, int>();

    static void AddItemToInventory(string item, int quantity)
    {
        if(inventory.ContainsKey(item))
        {
            inventory[item] += quantity;
        }
        else
        {
            inventory.Add(item, quantity);
        }
    }

    static void RemoveItemFromInventory(string item, int quantity)
    {
        if(inventory.ContainsKey(item))
        {
            if(inventory[item] >= quantity)
            {
                inventory[item] -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough quantity in inventory.");
            }
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
        }
    }

    static void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach(var item in inventory)
        {
            Console.WriteLine($"Item: {item.Key}, Quantity: {item.Value}");
        }
    }

    static void Main(string[] args)
    {
        AddItemToInventory("Apple", 10);
        AddItemToInventory("Banana", 5);

        DisplayInventory();

        RemoveItemFromInventory("Apple", 3);
        RemoveItemFromInventory("Banana", 6);

        DisplayInventory();
    }
}
