
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by spaces:");
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');

        double[] numbers = Array.ConvertAll(tokens, double.Parse);
        Array.Sort(numbers);

        double median;
        if (numbers.Length % 2 == 0)
        {
            median = (numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2;
        }
        else
        {
            median = numbers[numbers.Length / 2];
        }

        Console.WriteLine($"Median: {median}");
    }
}
