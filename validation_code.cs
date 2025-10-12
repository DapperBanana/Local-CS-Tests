
using System;

class WeatherForecast
{
    static void Main()
    {
        Random random = new Random();
        string[] possibleConditions = { "Sunny", "Partly Cloudy", "Cloudy", "Rainy", "Snowy" };
        
        int temperature = random.Next(-10, 40);
        int chanceOfRain = random.Next(0, 100);
        string condition = possibleConditions[random.Next(0, possibleConditions.Length)];

        Console.WriteLine("Weather Forecast:");
        Console.WriteLine($"Temperature: {temperature}°C");
        Console.WriteLine($"Chance of Rain: {chanceOfRain}%");
        Console.WriteLine($"Condition: {condition}");
        
        if (temperature > 20 && chanceOfRain < 50 && condition != "Snowy")
        {
            Console.WriteLine("It's a nice day, perfect for outdoor activities!");
        }
        else
        {
            Console.WriteLine("You might want to carry an umbrella with you today.");
        }
    }
}
