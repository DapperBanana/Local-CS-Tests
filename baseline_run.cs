
using System;

class WeatherForecast
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecasting System!");

        // Get user input
        Console.Write("Enter the current temperature in Celsius: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        // Determine weather conditions based on temperature
        string weatherCondition = "";
        if (temperature > 30)
        {
            weatherCondition = "Hot";
        }
        else if (temperature >= 20 && temperature <= 30)
        {
            weatherCondition = "Warm";
        }
        else if (temperature >= 10 && temperature < 20)
        {
            weatherCondition = "Cool";
        }
        else
        {
            weatherCondition = "Cold";
        }

        // Display the weather forecast
        Console.WriteLine($"The current weather condition is {weatherCondition}.");
    }
}
