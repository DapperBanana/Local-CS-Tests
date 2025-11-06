
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 5, 14, 3, 22, 8 };

        int max = FindLargestElement(numbers);

        Console.WriteLine("The largest element in the list is: " + max);
    }

    static int FindLargestElement(List<int> numbers)
    {
        int max = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }
}
