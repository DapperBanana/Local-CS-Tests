
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        double average = numbers.Average();

        Console.WriteLine($"Average: {average}");
    }
}
