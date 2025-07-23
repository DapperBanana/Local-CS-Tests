
using System;

class WeatherForecastingSystem
{
    static void Main()
    {
        Random random = new Random();
        int temperature = random.Next(-10, 40);
        int humidity = random.Next(0, 100);

        Console.WriteLine("Welcome to the Weather Forecasting System!");
        Console.WriteLine("Current Temperature: " + temperature + "°C");
        Console.WriteLine("Current Humidity: " + humidity + "%");

        if (temperature < 0)
        {
            Console.WriteLine("It's freezing cold outside, make sure to dress warmly!");
        }
        else if (temperature >= 0 && temperature < 10)
        {
            Console.WriteLine("It's cold outside, you may need a jacket!");
        }
        else if (temperature >= 10 && temperature < 20)
        {
            Console.WriteLine("It's mild outside, enjoy the pleasant weather!");
        }
        else if (temperature >= 20 && temperature < 30)
        {
            Console.WriteLine("It's warm and sunny outside, perfect weather!");
        }
        else
        {
            Console.WriteLine("It's hot outside, stay hydrated!");
        }

        if (humidity < 30)
        {
            Console.WriteLine("The air is dry, consider using a moisturizer.");
        }
        else if (humidity >= 30 && humidity < 70)
        {
            Console.WriteLine("The air is comfortable, enjoy the moderate humidity!");
        }
        else
        {
            Console.WriteLine("The air is humid, stay cool and hydrated!");
        }
    }
}
