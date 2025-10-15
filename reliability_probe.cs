
using System;
using System.Collections.Generic;

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
        HashSet<int> set = new HashSet<int>();
        foreach (int num in numbers)
        {
            set.Add(num);
        }

        int maxLength = 0;
        List<int> longestSequence = new List<int>();

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                List<int> currentSequence = new List<int> { currentNum };

                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentSequence.Add(currentNum);
                }

                if (currentSequence.Count > maxLength)
                {
                    maxLength = currentSequence.Count;
                    longestSequence = currentSequence;
                }
            }
        }

        return longestSequence;
    }
}
