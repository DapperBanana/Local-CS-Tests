
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list of numbers
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();
        string[] numbersStr = input.Split(' ');
        double[] numbers = Array.ConvertAll(numbersStr, Double.Parse);

        // Sort the numbers
        Array.Sort(numbers);

        // Calculate the median
        double median;
        if (numbers.Length % 2 == 0)
        {
            median = (numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2.0;
        }
        else
        {
            median = numbers[numbers.Length / 2];
        }

        // Output the result
        Console.WriteLine($"The median of the list of numbers is: {median}");
    }
}
