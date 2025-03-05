
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
        InventoryItem newItem = new InventoryItem(name, quantity);
        inventory.Add(newItem);
    }

    public void DisplayInventory()
    {
        foreach (var item in inventory)
        {
            Console.WriteLine($"Item: {item.Name}, Quantity: {item.Quantity}");
        }
    }

    public void UpdateItemQuantity(string name, int newQuantity)
    {
        foreach (var item in inventory)
        {
            if (item.Name == name)
            {
                item.Quantity = newQuantity;
                return;
            }
        }
        Console.WriteLine("Item not found in inventory.");
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        ims.AddItem("Apples", 10);
        ims.AddItem("Oranges", 5);

        ims.DisplayInventory();

        ims.UpdateItemQuantity("Apples", 15);

        ims.DisplayInventory();
    }
}
