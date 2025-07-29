
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 5, 6, 3, 7 };

        List<int> uniqueNumbers = RemoveDuplicates(numbers);

        foreach (int num in uniqueNumbers)
        {
            Console.WriteLine(num);
        }
    }

    static List<int> RemoveDuplicates(List<int> numbers)
    {
        List<int> uniqueNumbers = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in numbers)
        {
            if (!seen.Contains(num))
            {
                seen.Add(num);
                uniqueNumbers.Add(num);
            }
        }

        return uniqueNumbers;
    }
}
