
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int temperature = random.Next(-10, 40);
        string skyConditions = random.Next(0, 2) == 0 ? "clear" : "cloudy";

        Console.WriteLine("Welcome to the weather forecasting system!");
        Console.WriteLine("Today's weather forecast:");
        Console.WriteLine($"Temperature: {temperature}°C");
        Console.WriteLine($"Sky conditions: {skyConditions}");

        Console.Write("Enter the day of the week to get the forecast (e.g. Monday): ");
        string day = Console.ReadLine();

        Console.WriteLine($"Weather forecast for {day}:");
        Console.WriteLine($"Temperature: {temperature + random.Next(-5, 5)}°C");
        Console.WriteLine($"Sky conditions: {(random.Next(0, 2) == 0 ? "clear" : "cloudy")}");
    }
}
