
using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Item(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }

    class Program
    {
        static List<Item> inventory = new List<Item>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Inventory Management System");
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Display inventory");
                Console.WriteLine("3. Update quantity of an item");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        DisplayInventory();
                        break;
                    case 3:
                        UpdateQuantity();
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddItem()
        {
            Console.Write("Enter the name of the item: ");
            string name = Console.ReadLine();
            Console.Write("Enter the quantity of the item: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Item newItem = new Item(name, quantity);
            inventory.Add(newItem);

            Console.WriteLine("Item added successfully.");
        }

        static void DisplayInventory()
        {
            if(inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
            else
            {
                Console.WriteLine("Inventory:");
                foreach(Item item in inventory)
                {
                    Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}");
                }
            }
        }

        static void UpdateQuantity()
        {
            Console.Write("Enter the name of the item to update quantity: ");
            string name = Console.ReadLine();
            Console.Write("Enter the new quantity: ");
            int newQuantity = Convert.ToInt32(Console.ReadLine());

            Item itemToUpdate = inventory.Find(i => i.Name == name);
            if(itemToUpdate != null)
            {
                itemToUpdate.Quantity = newQuantity;
                Console.WriteLine("Quantity updated successfully.");
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }
        }
    }
}
