
using System;

class WeatherForecast
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecasting System");
        Console.WriteLine("Please enter the current weather conditions (sunny, cloudy, rainy, snowy): ");
        string input = Console.ReadLine();

        string forecast = GenerateForecast(input);
        Console.WriteLine("The weather forecast for tomorrow is: " + forecast);
    }

    static string GenerateForecast(string currentWeather)
    {
        Random rand = new Random();
        string[] possibleForecasts = { "sunny", "cloudy", "rainy", "snowy" };

        if (currentWeather == "sunny")
        {
            int index = rand.Next(1, 3); // generate random number between 1 and 2
            return possibleForecasts[index];
        }
        else if (currentWeather == "cloudy")
        {
            int index = rand.Next(0, 2); // generate random number between 0 and 1
            return possibleForecasts[index];
        }
        else if (currentWeather == "rainy")
        {
            int index = rand.Next(0, 3); // generate random number between 0 and 2
            return possibleForecasts[index];
        }
        else if (currentWeather == "snowy")
        {
            int index = rand.Next(2, 4); // generate random number between 2 and 3
            return possibleForecasts[index];
        }
        else
        {
            return "unknown";
        }
    }
}
