
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 4, 5, 6, 7, 10, 11, 12, 13, 15 };

        List<int> longestSequence = FindLongestConsecutiveSequence(numbers);

        Console.WriteLine("Longest consecutive sequence:");
        foreach (var num in longestSequence)
        {
            Console.Write(num + " ");
        }
    }

    static List<int> FindLongestConsecutiveSequence(List<int> numbers)
    {
        HashSet<int> numSet = new HashSet<int>(numbers);
        int maxLength = 0;
        List<int> longestSequence = new List<int>();

        foreach (int num in numbers)
        {
            int currentLength = 1;
            List<int> currentSequence = new List<int> { num };

            int nextNum = num + 1;
            while (numSet.Contains(nextNum))
            {
                currentLength++;
                currentSequence.Add(nextNum);
                nextNum++;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                longestSequence = currentSequence;
            }
        }

        return longestSequence;
    }
}
