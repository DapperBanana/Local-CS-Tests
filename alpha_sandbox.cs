
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>{5, 10, 15, 20, 25};

        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = sum / numbers.Count;
        Console.WriteLine("Average: " + average);
    }
}
