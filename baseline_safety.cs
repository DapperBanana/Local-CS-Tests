
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 3, 5, 3, 7, 1, 9, 5 };

        List<int> uniqueNumbers = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (!seen.Contains(number))
            {
                uniqueNumbers.Add(number);
                seen.Add(number);
            }
        }

        foreach (int uniqueNumber in uniqueNumbers)
        {
            Console.WriteLine(uniqueNumber);
        }
    }
}
