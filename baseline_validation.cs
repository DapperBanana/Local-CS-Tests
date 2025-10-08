
using System;

class WeatherForecast
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecast System");
        
        Console.Write("Enter the current temperature: ");
        int temperature = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the weather condition (sunny, cloudy, rainy): ");
        string weatherCondition = Console.ReadLine();

        if (temperature > 30 && weatherCondition == "sunny")
        {
            Console.WriteLine("It's hot and sunny. Remember to stay hydrated and wear sunscreen.");
        }
        else if (temperature > 20 && weatherCondition == "cloudy")
        {
            Console.WriteLine("It's mild and cloudy. A light jacket might be needed.");
        }
        else if (temperature < 15 && weatherCondition == "rainy")
        {
            Console.WriteLine("It's cold and rainy. Don't forget your umbrella and raincoat.");
        }
        else
        {
            Console.WriteLine("The weather conditions are moderate. Enjoy your day!");
        }
    }
}
