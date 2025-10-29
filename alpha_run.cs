
using System;

class WeatherForecastingSystem
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecasting System");
        
        Console.Write("Enter the current temperature in Celsius: ");
        double temperature = double.Parse(Console.ReadLine());
        
        string weatherForecast = GetWeatherForecast(temperature);
        
        Console.WriteLine("Today's weather forecast: " + weatherForecast);
    }

    static string GetWeatherForecast(double temperature)
    {
        if (temperature > 30)
        {
            return "Hot and sunny";
        }
        else if (temperature > 20)
        {
            return "Warm and partly sunny";
        }
        else if (temperature > 10)
        {
            return "Cool and cloudy";
        }
        else
        {
            return "Cold and rainy";
        }
    }
}
