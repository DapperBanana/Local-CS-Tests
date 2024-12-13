
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };

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

        Console.WriteLine("Original list:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("List with duplicates removed:");
        Console.WriteLine(string.Join(", ", uniqueNumbers));
    }
}
