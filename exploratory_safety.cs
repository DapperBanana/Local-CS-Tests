
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 5, 6, 7, 8, 10, 12, 13 };

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
        List<int> longestSequence = new List<int>();
        List<int> currentSequence = new List<int>();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] + 1 == numbers[i + 1])
            {
                currentSequence.Add(numbers[i]);
            }
            else
            {
                currentSequence.Add(numbers[i]);

                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence.Clear();
                    longestSequence.AddRange(currentSequence);
                }

                currentSequence.Clear();
            }
        }

        return longestSequence;
    }
}
