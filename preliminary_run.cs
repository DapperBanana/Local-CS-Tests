
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 100, 4, 200, 1, 3, 2 };

        int longestSequence = FindLongestConsecutiveSequence(numbers);
        Console.WriteLine("Longest consecutive sequence length: " + longestSequence);
    }

    static int FindLongestConsecutiveSequence(List<int> numbers)
    {
        HashSet<int> numberSet = new HashSet<int>(numbers);
        int longestSequence = 0;

        foreach (int num in numbers)
        {
            int currentSequence = 1;

            if (!numberSet.Contains(num - 1))
            {
                while (numberSet.Contains(num + currentSequence))
                {
                    currentSequence++;
                }

                longestSequence = Math.Max(longestSequence, currentSequence);
            }
        }

        return longestSequence;
    }
}
