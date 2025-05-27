
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Forecasting System\n");
        
        Random random = new Random();
        int temperature = random.Next(-10, 40); // Generate a random temperature between -10 and 40 degrees Celsius

        Console.WriteLine("Today's Temperature: " + temperature + "°C");

        string weather = "";
        if (temperature < 0)
        {
            weather = "It's freezing cold outside! Make sure to bundle up.";
        }
        else if (temperature >= 0 && temperature < 10)
        {
            weather = "It's cold outside. Don't forget your jacket.";
        }
        else if (temperature >= 10 && temperature < 20)
        {
            weather = "It's cool outside. A light jacket should be enough.";
        }
        else if (temperature >= 20 && temperature < 30)
        {
            weather = "It's warm outside. Enjoy the pleasant weather!";
        }
        else
        {
            weather = "It's hot outside. Stay hydrated and wear light clothing.";
        }

        Console.WriteLine("Weather: " + weather);
    }
}
