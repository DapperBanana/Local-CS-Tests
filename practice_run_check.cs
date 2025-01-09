
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 4, 5, 6, 8, 9, 10, 11 };

        List<int> longestSequence = FindLongestConsecutiveSequence(numbers);
        
        Console.WriteLine("Longest consecutive sequence:");
        Console.WriteLine(string.Join(", ", longestSequence));
    }

    static List<int> FindLongestConsecutiveSequence(List<int> numbers)
    {
        List<int> longestSequence = new List<int>();
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

        foreach (int num in numbers)
        {
            if (!uniqueNumbers.Contains(num - 1))
            {
                List<int> currentSequence = new List<int>() { num };

                int currentNum = num + 1;
                while (uniqueNumbers.Contains(currentNum))
                {
                    currentSequence.Add(currentNum);
                    currentNum++;
                }

                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = currentSequence;
                }
            }
        }

        return longestSequence;
    }
}
