
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };
        
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        
        double average = (double)sum / numbers.Count;
        
        Console.WriteLine("Average: " + average);
    }
}
