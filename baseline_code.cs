
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 3, 5, 6, 7, 7 };

        List<int> uniqueNumbers = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (seen.Add(number))
            {
                uniqueNumbers.Add(number);
            }
        }

        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
