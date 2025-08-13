
using System;

class StockTradingSystem
{
    static double balance = 10000.00;
    static double stockPrice = 50.00;
    static int stockQuantity = 0;

    static void Main()
    {
        Console.WriteLine("Welcome to the Stock Trading System!");
        
        while (true)
        {
            Console.WriteLine($"Balance: ${balance}  Stock Price: ${stockPrice}  Stock Quantity: {stockQuantity}");
            Console.WriteLine("Enter 'B' to buy, 'S' to sell, or 'Q' to quit:");

            char choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'B':
                    BuyStock();
                    break;

                case 'S':
                    SellStock();
                    break;

                case 'Q':
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
        Console.WriteLine("Enter the quantity of stock to buy:");
        int quantityToBuy = Convert.ToInt32(Console.ReadLine());

        double totalPrice = stockPrice * quantityToBuy;

        if (totalPrice > balance)
        {
            Console.WriteLine("Insufficient funds to buy stock.");
        }
        else
        {
            balance -= totalPrice;
            stockQuantity += quantityToBuy;
            Console.WriteLine($"Bought {quantityToBuy} stocks for ${totalPrice}");
        }
    }

    static void SellStock()
    {
        Console.WriteLine("Enter the quantity of stock to sell:");
        int quantityToSell = Convert.ToInt32(Console.ReadLine());

        if (quantityToSell > stockQuantity)
        {
            Console.WriteLine("Not enough stocks to sell.");
        }
        else
        {
            double totalPrice = stockPrice * quantityToSell;
            balance += totalPrice;
            stockQuantity -= quantityToSell;
            Console.WriteLine($"Sold {quantityToSell} stocks for ${totalPrice}");
        }
    }
}
