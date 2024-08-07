
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 5, 2, 8, 10 };

        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = sum / numbers.Count;

        Console.WriteLine("The average of the numbers is: " + average);
    }
}
