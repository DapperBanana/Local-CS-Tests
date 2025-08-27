
using System;

class WeatherForecast
{
    static void Main()
    {
        Random random = new Random();
        
        string[] weatherConditions = { "Sunny", "Cloudy", "Rainy", "Snowy" };
        
        int randomIndex = random.Next(weatherConditions.Length);
        string forecast = weatherConditions[randomIndex];
        
        Console.WriteLine("Today's weather forecast is: " + forecast);
    }
}
