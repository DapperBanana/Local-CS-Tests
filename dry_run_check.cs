
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 15, 20, 10, 30, 25, 40, 5 };

        int max = FindLargestElement(numbers);

        Console.WriteLine($"The largest element in the list is: {max}");
    }

    static int FindLargestElement(List<int> numbers)
    {
        int max = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}
