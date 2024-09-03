
using System;

class WeatherForecast
{
    static void Main()
    {
        string[] weatherConditions = { "Sunny", "Cloudy", "Rainy", "Snowy" };

        Random random = new Random();
        int randomNumber = random.Next(0, weatherConditions.Length);

        string currentWeather = weatherConditions[randomNumber];

        Console.WriteLine("Today's weather forecast:");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Weather condition: " + currentWeather);

        if (currentWeather == "Sunny")
        {
            Console.WriteLine("It's a sunny day! Don't forget to wear sunscreen.");
        }
        else if (currentWeather == "Cloudy")
        {
            Console.WriteLine("Looks like it's going to be overcast today.");
        }
        else if (currentWeather == "Rainy")
        {
            Console.WriteLine("Better grab an umbrella, it's raining today.");
        }
        else if (currentWeather == "Snowy")
        {
            Console.WriteLine("Snow is falling! Bundle up and stay warm.");
        }
    }
}
