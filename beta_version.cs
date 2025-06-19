
using System;
using System.Collections.Generic;

class InventorySystem
{
    static Dictionary<string, int> inventory = new Dictionary<string, int>();

    static void Main(string[] args)
    {
        string userInput;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Remove item from inventory");
            Console.WriteLine("3. View inventory");
            Console.WriteLine("4. Exit");

            userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    AddItem();
                    break;
                case "2":
                    RemoveItem();
                    break;
                case "3":
                    ViewInventory();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        } while(userInput != "4");
    }

    static void AddItem()
    {
        Console.WriteLine("Enter item name:");
        string itemName = Console.ReadLine();

        Console.WriteLine("Enter quantity:");
        int quantity = Convert.ToInt32(Console.ReadLine());

        if(inventory.ContainsKey(itemName))
        {
            inventory[itemName] += quantity;
        }
        else
        {
            inventory[itemName] = quantity;
        }

        Console.WriteLine($"{quantity} {itemName}(s) added to inventory");
    }

    static void RemoveItem()
    {
        Console.WriteLine("Enter item name to remove:");
        string itemName = Console.ReadLine();

        if(inventory.ContainsKey(itemName))
        {
            Console.WriteLine("Enter quantity to remove:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if(inventory[itemName] >= quantity)
            {
                inventory[itemName] -= quantity;
                Console.WriteLine($"{quantity} {itemName}(s) removed from inventory");
            }
            else
            {
                Console.WriteLine("Not enough quantity in inventory");
            }
        }
        else
        {
            Console.WriteLine("Item not found in inventory");
        }
    }

    static void ViewInventory()
    {
        Console.WriteLine("Inventory:");

        foreach(var item in inventory)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
