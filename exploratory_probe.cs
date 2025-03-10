
using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    class Program
    {
        static Dictionary<string, int> inventory = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            bool displayMenu = true;

            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        static bool MainMenu()
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. View Inventory");
            Console.WriteLine("2. Add Item to Inventory");
            Console.WriteLine("3. Remove Item from Inventory");
            Console.WriteLine("4. Exit Program");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ViewInventory();
                    return true;
                case "2":
                    AddItem();
                    return true;
                case "3":
                    RemoveItem();
                    return true;
                case "4":
                    return false;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    return true;
            }
        }

        static void ViewInventory()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
            else
            {
                Console.WriteLine("Current Inventory:");
                foreach (var item in inventory)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }

        static void AddItem()
        {
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();

            if (inventory.ContainsKey(itemName))
            {
                Console.WriteLine("Item already exists in inventory. Please use 'Remove Item' option to adjust quantity.");
            }
            else
            {
                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                inventory.Add(itemName, quantity);
                Console.WriteLine("Item added successfully to inventory.");
            }
        }

        static void RemoveItem()
        {
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();

            if (inventory.ContainsKey(itemName))
            {
                Console.Write("Enter quantity to remove: ");
                int quantity = int.Parse(Console.ReadLine());
                if (quantity >= inventory[itemName])
                {
                    inventory.Remove(itemName);
                }
                else
                {
                    inventory[itemName] -= quantity;
                }
                Console.WriteLine("Item removed successfully from inventory.");
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }
        }
    }
}
