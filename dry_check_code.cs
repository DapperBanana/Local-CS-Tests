
using System;

class WeatherForecast
{
    static void Main()
    {
        Random random = new Random();
        string[] weatherConditions = { "Sunny", "Cloudy", "Rainy", "Snowy" };
        
        Console.WriteLine("Weather Forecast for Today:");

        int weatherIndex = random.Next(0, weatherConditions.Length);
        string forecast = weatherConditions[weatherIndex];

        Console.WriteLine($"Today's weather: {forecast}");
    }
}
