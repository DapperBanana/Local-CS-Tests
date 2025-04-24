
using System;

class StockTradingSystem
{
    static void Main()
    {
        double startingBalance = 10000;
        double currentBalance = startingBalance;
        double stockPrice = 50;
        int stockQuantity = 0;

        Console.WriteLine("Welcome to the stock trading system!");
        Console.WriteLine($"Current balance: ${currentBalance}");

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Buy Stock");
            Console.WriteLine("2. Sell Stock");
            Console.WriteLine("3. View Account Information");
            Console.WriteLine("4. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the quantity of stock you would like to buy:");
                    int buyQuantity = int.Parse(Console.ReadLine());
                    double buyCost = stockPrice * buyQuantity;

                    if (buyCost > currentBalance)
                    {
                        Console.WriteLine("Insufficient funds!");
                    }
                    else
                    {
                        stockQuantity += buyQuantity;
                        currentBalance -= buyCost;
                        Console.WriteLine($"Bought {buyQuantity} stocks at ${stockPrice} each for a total cost of ${buyCost}");
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter the quantity of stock you would like to sell:");
                    int sellQuantity = int.Parse(Console.ReadLine());
                    
                    if (sellQuantity > stockQuantity)
                    {
                        Console.WriteLine("You do not own enough stock to sell!");
                    }
                    else
                    {
                        double sellPrice = stockPrice * sellQuantity;
                        stockQuantity -= sellQuantity;
                        currentBalance += sellPrice;
                        Console.WriteLine($"Sold {sellQuantity} stocks at ${stockPrice} each for a total profit of ${sellPrice}");
                    }
                    break;

                case 3:
                    Console.WriteLine($"Current balance: ${currentBalance}");
                    Console.WriteLine($"Current stock price: ${stockPrice}");
                    Console.WriteLine($"Current stock quantity: {stockQuantity}");
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the stock trading system!");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
