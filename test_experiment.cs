
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] weatherOptions = { "Sunny", "Cloudy", "Rainy", "Snowy" };

        Console.WriteLine("Welcome to the Weather Forecasting System!");

        while (true)
        {
            Console.WriteLine("\nEnter 'forecast' to get the weather forecast or 'exit' to quit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "forecast")
            {
                int randomIndex = random.Next(weatherOptions.Length);
                string weatherForecast = weatherOptions[randomIndex];
                Console.WriteLine("The weather forecast for today is: " + weatherForecast);
            }
            else if (input.ToLower() == "exit")
            {
                Console.WriteLine("Thank you for using the Weather Forecasting System. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
