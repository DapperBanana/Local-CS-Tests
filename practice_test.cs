
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list of numbers
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();
        string[] strNumbers = input.Split(' ');
        
        // Convert string array to int array
        int[] numbers = Array.ConvertAll(strNumbers, int.Parse);

        // Sort the array
        Array.Sort(numbers);

        // Calculate the median
        double median;
        int n = numbers.Length;
        if (n % 2 == 0)
        {
            median = (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0;
        }
        else
        {
            median = numbers[n / 2];
        }

        // Output the result
        Console.WriteLine("Median: " + median);
    }
}
