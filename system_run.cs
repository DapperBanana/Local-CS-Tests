
using System;

class WeatherForecastingSystem
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecasting System!");

        Console.WriteLine("Enter the current temperature in Fahrenheit:");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the current weather conditions (sunny, cloudy, rainy, snowy):");
        string conditions = Console.ReadLine();

        Console.WriteLine("Enter the current wind speed in mph:");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nWeather Forecast:");

        Console.WriteLine($"Temperature: {temperature}F");
        Console.WriteLine($"Conditions: {conditions}");
        Console.WriteLine($"Wind Speed: {windSpeed}mph");

        if (temperature > 80 && conditions.ToLower() == "sunny")
        {
            Console.WriteLine("It's a hot and sunny day! Stay hydrated!");
        }
        else if (temperature < 50 && conditions.ToLower() == "snowy")
        {
            Console.WriteLine("It's cold and snowy! Bundle up!");
        }
        else if (windSpeed > 20)
        {
            Console.WriteLine("It's windy outside! Hold onto your hats!");
        }
        else
        {
            Console.WriteLine("Enjoy the weather!");
        }
    }
}
