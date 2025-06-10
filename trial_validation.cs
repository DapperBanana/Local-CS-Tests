
using System;

class WeatherForecastingSystem
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecasting System!");
        
        // Get user input for weather conditions
        Console.Write("Enter today's temperature in Fahrenheit: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter today's weather (sunny, cloudy, rainy, snowy): ");
        string weather = Console.ReadLine();

        // Display weather forecast based on user input
        Console.WriteLine("\nToday's Weather Forecast:");
        Console.WriteLine("Temperature: " + temperature + "F");
        Console.WriteLine("Weather: " + weather);

        // Make a basic weather prediction
        if (temperature > 80 && weather == "sunny")
        {
            Console.WriteLine("It's going to be a hot and sunny day!");
        }
        else if (temperature < 50 && (weather == "rainy" || weather == "snowy"))
        {
            Console.WriteLine("It's going to be cold and wet today. Don't forget your umbrella!");
        }
        else
        {
            Console.WriteLine("The weather today is unpredictable. Stay safe!");
        }
    }
}
