
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by commas:");
        string input = Console.ReadLine();
        
        // Parse the input string into an array of numbers
        double[] numbers = input.Split(',').Select(double.Parse).ToArray();
        
        // Sort the array
        Array.Sort(numbers);
        
        // Calculate the median
        double median;
        int length = numbers.Length;
        if (length % 2 == 0)
        {
            median = (numbers[length / 2 - 1] + numbers[length / 2]) / 2;
        }
        else
        {
            median = numbers[length / 2];
        }
        
        Console.WriteLine("The median of the numbers is: " + median);
    }
}
