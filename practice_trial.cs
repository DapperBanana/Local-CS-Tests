
using System;

class WeatherForecast
{
    static void Main()
    {
        Random rnd = new Random();
        string[] weatherConditions = { "Sunny", "Cloudy", "Rainy", "Snowy" };
        
        int randIndex = rnd.Next(weatherConditions.Length);
        string currentWeather = weatherConditions[randIndex];
        
        Console.WriteLine("Today's weather forecast:");
        Console.WriteLine("=========================");
        Console.WriteLine("Condition: " + currentWeather);

        switch (currentWeather)
        {
            case "Sunny":
                Console.WriteLine("Don't forget to bring sunglasses!");
                break;
            case "Cloudy":
                Console.WriteLine("It might rain, so bring an umbrella!");
                break;
            case "Rainy":
                Console.WriteLine("Dress warmly and don't forget your raincoat!");
                break;
            case "Snowy":
                Console.WriteLine("Bundle up and wear snow boots!");
                break;
            default:
                Console.WriteLine("Unknown weather condition.");
                break;
        }
    }
}
