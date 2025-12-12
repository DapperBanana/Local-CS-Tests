using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 8, 1, 2, 9, 4 };
        
        // Sorting the list in ascending order
        numbers.Sort();
        
        // Display the sorted list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}