
using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

class InventoryManagementSystem
{
    private List<InventoryItem> inventory = new List<InventoryItem>();

    public void AddItem(string name, int quantity, double price)
    {
        inventory.Add(new InventoryItem { Name = name, Quantity = quantity, Price = price });
        Console.WriteLine($"{name} added to inventory.");
    }

    public void DisplayInventory()
    {
        foreach (var item in inventory)
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price}");
        }
    }

    public void UpdateQuantity(string name, int newQuantity)
    {
        var item = inventory.Find(i => i.Name == name);
        if (item != null)
        {
            item.Quantity = newQuantity;
            Console.WriteLine($"{name} quantity updated to {newQuantity}.");
        }
        else
        {
            Console.WriteLine($"{name} not found in inventory.");
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();
        
        ims.AddItem("Phone", 10, 500);
        ims.AddItem("Laptop", 5, 1000);

        ims.DisplayInventory();

        ims.UpdateQuantity("Phone", 15);

        ims.DisplayInventory();
    }
}
