
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 7, 1, 9, 5, 2, 4, 8, 6 };

        int max = FindLargestElement(numbers);

        Console.WriteLine("The largest element in the list is: " + max);
    }

    static int FindLargestElement(List<int> list)
    {
        int max = list[0];

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
