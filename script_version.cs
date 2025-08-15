
using System;

class WeatherForecast
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecast System!");

        Console.WriteLine("Enter the date for which you want to forecast the weather (DD/MM/YYYY):");
        string date = Console.ReadLine();

        Random random = new Random();
        int temperature = random.Next(-10, 40);
        int humidity = random.Next(0, 100);
        string conditions = GetWeatherConditions();

        Console.WriteLine($"\nWeather forecast for {date}:");
        Console.WriteLine($"Temperature: {temperature}°C");
        Console.WriteLine($"Humidity: {humidity}%");
        Console.WriteLine($"Conditions: {conditions}");

        Console.WriteLine("\nThank you for using the Weather Forecast System!");
    }

    static string GetWeatherConditions()
    {
        string[] possibleConditions = { "Sunny", "Cloudy", "Partly Cloudy", "Rainy", "Snowy" };

        Random random = new Random();
        int index = random.Next(possibleConditions.Length);

        return possibleConditions[index];
    }
}
