
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = sum / numbers.Count;

        Console.WriteLine("The average of the numbers is: " + average);
    }
}
