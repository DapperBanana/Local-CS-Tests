
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        double[] parsedNumbers = Array.ConvertAll(numbers, Double.Parse);
        Array.Sort(parsedNumbers);

        double median;
        if (parsedNumbers.Length % 2 == 0)
        {
            median = (parsedNumbers[parsedNumbers.Length / 2 - 1] + parsedNumbers[parsedNumbers.Length / 2]) / 2;
        }
        else
        {
            median = parsedNumbers[parsedNumbers.Length / 2];
        }

        Console.WriteLine($"The median of the list is: {median}");
    }
}
