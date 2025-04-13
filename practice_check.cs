
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };

        List<int> uniqueNumbers = new List<int>();
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (!seenNumbers.Contains(number))
            {
                uniqueNumbers.Add(number);
                seenNumbers.Add(number);
            }
        }

        foreach (int number in uniqueNumbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
}
