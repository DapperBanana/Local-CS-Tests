
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 4, 6, 7, 8, 7 };

        List<int> uniqueNumbers = new List<int>();
        HashSet<int> set = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (set.Add(number))
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
