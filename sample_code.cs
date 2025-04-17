
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();
        
        string[] numberStrings = input.Split(' ');
        int[] numbers = new int[numberStrings.Length];

        for (int i = 0; i < numberStrings.Length; i++)
        {
            numbers[i] = Convert.ToInt32(numberStrings[i]);
        }

        Array.Sort(numbers);

        double median;
        if (numbers.Length % 2 == 0)
        {
            int middleIndex1 = numbers.Length / 2 - 1;
            int middleIndex2 = numbers.Length / 2;
            median = (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;
        }
        else
        {
            int middleIndex = numbers.Length / 2;
            median = numbers[middleIndex];
        }

        Console.WriteLine($"The median of the list is {median}");
    }
}
