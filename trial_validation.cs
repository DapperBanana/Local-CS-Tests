
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 9, 1, 3 };
        
        numbers.Sort();

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
