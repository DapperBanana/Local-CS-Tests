
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double> { 2.5, 5.5, 8.0, 3.5, 6.5 };

        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }

        double average = sum / numbers.Count;

        Console.WriteLine("The average of the elements in the list is: " + average);
    }
}
