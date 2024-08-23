
using System;

class StockTradingSystem
{
    static double balance = 10000;
    static double stockPrice = 50;
    static int stockQuantity = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Balance: $" + balance);
            Console.WriteLine("Stock Price: $" + stockPrice);
            Console.WriteLine("Stock Quantity: " + stockQuantity);

            Console.WriteLine("\n1. Buy Stock\n2. Sell Stock\n3. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter quantity:");
                    int buyQuantity = int.Parse(Console.ReadLine());
                    BuyStock(buyQuantity);
                    break;
                case 2:
                    Console.WriteLine("Enter quantity:");
                    int sellQuantity = int.Parse(Console.ReadLine());
                    SellStock(sellQuantity);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void BuyStock(int quantity)
    {
        double totalCost = stockPrice * quantity;
        if (totalCost <= balance)
        {
            balance -= totalCost;
            stockQuantity += quantity;
            Console.WriteLine("Bought " + quantity + " stocks.");
        }
        else
        {
            Console.WriteLine("Not enough balance to buy " + quantity + " stocks.");
        }
    }

    static void SellStock(int quantity)
    {
        if (quantity <= stockQuantity)
        {
            double totalEarnings = stockPrice * quantity;
            balance += totalEarnings;
            stockQuantity -= quantity;
            Console.WriteLine("Sold " + quantity + " stocks.");
        }
        else
        {
            Console.WriteLine("Not enough stocks to sell " + quantity + " stocks.");
        }
    }
}
