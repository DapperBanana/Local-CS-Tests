
using System;

class StockTradingSystem
{
    static double balance = 1000;
    static double stockPrice = 50;
    static int stockQuantity = 10;

    static void Main()
    {
        Console.WriteLine("Welcome to the Stock Trading System!");
        
        while (true)
        {
            Console.WriteLine("\n1. Buy Stock");
            Console.WriteLine("2. Sell Stock");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    BuyStock();
                    break;
                case 2:
                    SellStock();
                    break;
                case 3:
                    CheckBalance();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void BuyStock()
    {
        Console.Write("Enter the quantity of stock to buy: ");
        int quantity = int.Parse(Console.ReadLine());
        
        double totalCost = stockPrice * quantity;
        if (totalCost > balance)
        {
            Console.WriteLine("Insufficient balance to buy stock.");
            return;
        }
        
        balance -= totalCost;
        stockQuantity += quantity;
        Console.WriteLine($"Stock bought successfully. New balance: ${balance}");
    }

    static void SellStock()
    {
        Console.Write("Enter the quantity of stock to sell: ");
        int quantity = int.Parse(Console.ReadLine());
        
        if (quantity > stockQuantity)
        {
            Console.WriteLine("Not enough stock to sell.");
            return;
        }
        
        double totalProfit = stockPrice * quantity;
        balance += totalProfit;
        stockQuantity -= quantity;
        Console.WriteLine($"Stock sold successfully. New balance: ${balance}");
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Current balance: ${balance}");
        Console.WriteLine($"Current stock quantity: {stockQuantity}");
    }
}
