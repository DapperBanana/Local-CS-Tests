
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 5, 6, 7, 8, 10, 12, 13, 14, 15 };

        List<int> longestSequence = FindLongestConsecutiveSequence(numbers);

        Console.WriteLine("Longest consecutive sequence:");
        foreach (int num in longestSequence)
        {
            Console.Write(num + " ");
        }
    }

    static List<int> FindLongestConsecutiveSequence(List<int> numbers)
    {
        numbers.Sort();

        List<int> currentSequence = new List<int>();
        List<int> longestSequence = new List<int>();

        foreach (int num in numbers)
        {
            if (currentSequence.Count == 0 || num == currentSequence[currentSequence.Count - 1] + 1)
            {
                currentSequence.Add(num);
            }
            else
            {
                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence.Clear();
                    longestSequence.AddRange(currentSequence);
                }
                currentSequence.Clear();
                currentSequence.Add(num);
            }
        }

        if (currentSequence.Count > longestSequence.Count)
        {
            longestSequence.Clear();
            longestSequence.AddRange(currentSequence);
        }

        return longestSequence;
    }
}
