using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double> { 10.5, 20.0, 30.5, 40.0, 50.5 };
        double average = numbers.Average();
        Console.WriteLine("The average is: " + average);
    }
}