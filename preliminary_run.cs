
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 5, 20, 15, 30 };

        int max = FindMax(numbers);

        Console.WriteLine("The largest element in the list is: " + max);
    }

    static int FindMax(List<int> numbers)
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
