
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 35, 7, 22, 45, 12, 18 };

        int max = FindLargest(numbers);

        Console.WriteLine("The largest element in the list is: " + max);
    }

    static int FindLargest(List<int> numbers)
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
