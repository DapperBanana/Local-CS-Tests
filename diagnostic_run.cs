
using System;

class WeatherForecastingSystem
{
    static void Main()
    {
        // Generate a random temperature and precipitation forecast
        Random rnd = new Random();
        int temperature = rnd.Next(-10, 40);
        bool isRaining = rnd.Next(0, 2) == 1;

        Console.WriteLine("Today's weather forecast:");
        Console.WriteLine($"Temperature: {temperature}°C");
        Console.WriteLine($"Precipitation: {(isRaining ? "Raining" : "Dry")}");

        // Ask the user for their location to provide a custom forecast
        Console.Write("\nEnter your location: ");
        string location = Console.ReadLine();

        // Generate a custom forecast based on the user's location
        int customTemperature = rnd.Next(-10, 40);
        bool customIsRaining = rnd.Next(0, 2) == 1;

        Console.WriteLine($"\nCustom forecast for {location}:");
        Console.WriteLine($"Temperature: {customTemperature}°C");
        Console.WriteLine($"Precipitation: {(customIsRaining ? "Raining" : "Dry")}");
    }
}
