
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 5, 20, 15, 25 };

        int max = FindLargestElement(numbers);

        Console.WriteLine("The largest number in the list is: " + max);
    }

    static int FindLargestElement(List<int> numbers)
    {
        int max = numbers[0];

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
