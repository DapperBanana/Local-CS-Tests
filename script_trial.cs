
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine($"List: {string.Join(", ", numbers)}");
        Console.WriteLine($"Sum of all elements: {SumList(numbers)}");
    }

    static int SumList(List<int> list)
    {
        int sum = 0;
        foreach (int num in list)
        {
            sum += num;
        }
        return sum;
    }
}
