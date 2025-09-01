
using System;

class WeatherForecastingSystem
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecasting System");

        Console.Write("Enter the temperature (in Celsius): ");
        int temperature = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the type of weather (sunny, cloudy, rainy, or snowy): ");
        string weatherType = Console.ReadLine();

        Console.Write("Enter the wind speed (in km/h): ");
        int windSpeed = Convert.ToInt32(Console.ReadLine());

        // Weather prediction logic
        string prediction;
        if (temperature >= 30 && weatherType == "sunny" && windSpeed < 10)
        {
            prediction = "It will be a hot and sunny day with light winds.";
        }
        else if (temperature >= 20 && temperature < 30 && (weatherType == "sunny" || weatherType == "cloudy") && windSpeed < 20)
        {
            prediction = "Expect a pleasant day with moderate winds.";
        }
        else if (temperature < 20 && (weatherType == "cloudy" || weatherType == "rainy"))
        {
            prediction = "It might rain or be cool.";
        }
        else if (temperature < 0 && weatherType == "snowy")
        {
            prediction = "Get ready for some snow!";
        }
        else
        {
            prediction = "Could not make a specific prediction for the weather.";
        }

        Console.WriteLine("\nWeather Forecast:");
        Console.WriteLine(prediction);

        Console.ReadLine();
    }
}
