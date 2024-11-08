
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of numbers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Find the sum of all elements
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("The sum of all elements in the list is: " + sum);
    }
}
