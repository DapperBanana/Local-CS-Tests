
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        
        double average = (double)sum / numbers.Count;
        
        Console.WriteLine("The average of the elements in the list is: " + average);
    }
}
