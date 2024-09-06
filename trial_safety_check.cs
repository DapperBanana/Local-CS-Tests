
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list of numbers
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        double[] convertedNumbers = Array.ConvertAll(numbers, double.Parse);

        // Sort the numbers
        Array.Sort(convertedNumbers);

        // Calculate the median
        double median;
        if (convertedNumbers.Length % 2 == 0)
        {
            // If the list has an even number of elements, average the middle two
            median = (convertedNumbers[convertedNumbers.Length / 2] + convertedNumbers[convertedNumbers.Length / 2 - 1]) / 2;
        }
        else
        {
            // If the list has an odd number of elements, take the middle number
            median = convertedNumbers[convertedNumbers.Length / 2];
        }

        // Output the median
        Console.WriteLine("The median is: " + median);
    }
}
