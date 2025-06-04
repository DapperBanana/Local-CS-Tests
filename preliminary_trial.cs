
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 5, 6, 7, 8, 10, 11, 12 };

        List<int> longestSequence = FindLongestConsecutiveSequence(numbers);

        Console.WriteLine("Longest consecutive sequence:");
        foreach (int num in longestSequence)
        {
            Console.Write(num + " ");
        }
    }

    static List<int> FindLongestConsecutiveSequence(List<int> numbers)
    {
        HashSet<int> numSet = new HashSet<int>(numbers);
        List<int> longestSequence = new List<int>();

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                List<int> currentSequence = new List<int> { num };

                int nextNum = num + 1;
                while (numSet.Contains(nextNum))
                {
                    currentSequence.Add(nextNum);
                    nextNum++;
                }

                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = new List<int>(currentSequence);
                }
            }
        }

        return longestSequence;
    }
}
