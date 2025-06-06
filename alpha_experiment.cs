
using System;

class WeatherForecast
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecasting System!");
        
        Random random = new Random();
        int temperature = random.Next(-10, 40);
        int humidity = random.Next(0, 100);
        int windSpeed = random.Next(0, 20);
        string conditions = GetWeatherConditions(random.Next(0, 3));

        Console.WriteLine($"Today's weather forecast:");
        Console.WriteLine($"Temperature: {temperature}°C");
        Console.WriteLine($"Humidity: {humidity}%");
        Console.WriteLine($"Wind Speed: {windSpeed} km/h");
        Console.WriteLine($"Conditions: {conditions}");
    }

    static string GetWeatherConditions(int index)
    {
        string[] conditions = { "Sunny", "Cloudy", "Rainy" };
        
        return conditions[index];
    }
}
