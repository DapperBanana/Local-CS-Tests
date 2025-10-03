
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 5, 6, 7, 8, 10, 11, 12, 13 };

        int maxLength = 0;
        List<int> longestSequence = new List<int>();

        List<int> sortedNumbers = numbers.OrderBy(x => x).ToList();
        
        List<int> currentSequence = new List<int> { sortedNumbers[0] };

        for (int i = 1; i < sortedNumbers.Count; i++)
        {
            if (sortedNumbers[i] == currentSequence.Last() + 1)
            {
                currentSequence.Add(sortedNumbers[i]);
                
                if (currentSequence.Count > maxLength)
                {
                    maxLength = currentSequence.Count;
                    longestSequence = new List<int>(currentSequence);
                }
            }
            else
            {
                currentSequence = new List<int> { sortedNumbers[i] };
            }
        }

        Console.WriteLine("Longest consecutive sequence: " + string.Join(", ", longestSequence));
        Console.WriteLine("Length of longest consecutive sequence: " + maxLength);
    }
}
