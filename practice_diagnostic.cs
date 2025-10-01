
using System;

class WeatherForecast
{
    static void Main()
    {
        Random random = new Random();
        int temperature = random.Next(-10, 40);
        int humidity = random.Next(0, 100);
        int windSpeed = random.Next(0, 50);

        Console.WriteLine("Weather Forecast:");
        Console.WriteLine("-----------------");
        Console.WriteLine("Temperature: " + temperature + "°C");
        Console.WriteLine("Humidity: " + humidity + "%");
        Console.WriteLine("Wind Speed: " + windSpeed + " km/h");

        if (temperature <= 0)
        {
            Console.WriteLine("It's freezing cold outside. Bundle up!");
        }
        else if (temperature > 0 && temperature < 10)
        {
            Console.WriteLine("It's chilly outside. Wear a jacket.");
        }
        else if (temperature >= 10 && temperature < 20)
        {
            Console.WriteLine("It's cool outside. Enjoy the weather!");
        }
        else if (temperature >= 20 && temperature < 30)
        {
            Console.WriteLine("It's warm outside. Perfect weather!");
        }
        else
        {
            Console.WriteLine("It's hot outside. Stay hydrated!");
        }
    }
}
