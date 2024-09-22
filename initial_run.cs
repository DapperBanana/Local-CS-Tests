
using System;

class WeatherForecast
{
    static void Main()
    {
        Console.WriteLine("=============================");
        Console.WriteLine("   Text-Based Weather System");
        Console.WriteLine("=============================");

        string[] weatherOptions = { "Sunny", "Cloudy", "Rainy", "Snowy" };
        Random rand = new Random();
        int index = rand.Next(weatherOptions.Length);

        Console.WriteLine("\nToday's weather forecast:");
        Console.WriteLine(weatherOptions[index]);
    }
}
