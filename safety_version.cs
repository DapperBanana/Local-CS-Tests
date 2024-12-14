
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 5, 30, 15 };

        int max = FindLargestElement(numbers);

        Console.WriteLine("The largest element in the list is: " + max);
    }

    static int FindLargestElement(List<int> list)
    {
        int max = int.MinValue;

        foreach (int num in list)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}
