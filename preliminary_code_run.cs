
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers separated by spaces:");
        string input = Console.ReadLine();

        // Convert the input string to an array of numbers
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        // Sort the array
        Array.Sort(numbers);

        // Find the median
        double median;
        if (numbers.Length % 2 == 0)
        {
            median = (double)(numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2;
        }
        else
        {
            median = numbers[numbers.Length / 2];
        }

        // Display the median
        Console.WriteLine($"The median is: {median}");
    }
}
