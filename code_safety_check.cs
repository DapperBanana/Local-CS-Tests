
using System;

class StockTradingSystem
{
    static void Main(string[] args)
    {
        double balance = 10000.0;
        double stockPrice = 50.0;
        int sharesOwned = 0;

        while (true)
        {
            Console.WriteLine($"Current Balance: {balance:C}");
            Console.WriteLine($"Stock Price: {stockPrice:C}");
            Console.WriteLine($"Shares Owned: {sharesOwned}");

            Console.WriteLine("\nEnter 'B' to buy, 'S' to sell, or 'Q' to quit:");
            char choice = Console.ReadLine().ToUpper()[0];

            if (choice == 'Q')
            {
                break;
            }
            else if (choice == 'B')
            {
                Console.WriteLine("Enter the number of shares to buy:");
                int numShares = int.Parse(Console.ReadLine());

                double totalCost = numShares * stockPrice;
                if (totalCost > balance)
                {
                    Console.WriteLine("Insufficient funds!");
                }
                else
                {
                    sharesOwned += numShares;
                    balance -= totalCost;
                }
            }
            else if (choice == 'S')
            {
                Console.WriteLine("Enter the number of shares to sell:");
                int numShares = int.Parse(Console.ReadLine());

                if (numShares > sharesOwned)
                {
                    Console.WriteLine("Insufficient shares!");
                }
                else
                {
                    double totalEarnings = numShares * stockPrice;
                    sharesOwned -= numShares;
                    balance += totalEarnings;
                }
            }

            // Simulate stock price fluctuations
            Random random = new Random();
            stockPrice += random.NextDouble() * 10 - 5;
        }

        Console.WriteLine($"Final Balance: {balance:C}");
        Console.WriteLine($"Final Shares Owned: {sharesOwned}");
    }
}
