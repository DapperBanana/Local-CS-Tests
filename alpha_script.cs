using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 56, 23, 89, 45, 19 };
        int largest = FindLargest(numbers);
        Console.WriteLine($"The largest element is: {largest}");
    }

    static int FindLargest(List<int> list)
    {
        if (list == null || list.Count == 0)
            throw new ArgumentException("The list cannot be null or empty.");

        int max = list[0];
        foreach (int num in list)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}