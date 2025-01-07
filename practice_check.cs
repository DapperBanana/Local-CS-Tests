
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 7, 3, 5, 2, 8, 4 };

        int sum = FindSum(numbers);

        Console.WriteLine("Sum of all elements in the list: " + sum);
    }

    static int FindSum(List<int> numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }
}
