
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 4, 1, 2, 3, 7, 8, 9, 10 };

        Console.WriteLine("List of numbers:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        List<int> longestSequence = FindLongestConsecutiveSequence(numbers);

        Console.Write("\nLongest consecutive sequence: ");
        foreach (int num in longestSequence)
        {
            Console.Write(num + " ");
        }
    }

    static List<int> FindLongestConsecutiveSequence(List<int> numbers)
    {
        HashSet<int> set = new HashSet<int>(numbers);
        int maxLength = 0;
        List<int> longestSequence = new List<int>();

        foreach (int num in numbers)
        {
            int length = 1;
            int currentNum = num;

            while (set.Contains(currentNum + 1))
            {
                length++;
                currentNum++;
            }

            if (length > maxLength)
            {
                maxLength = length;
                longestSequence.Clear();
                for (int i = num; i < num + length; i++)
                {
                    longestSequence.Add(i);
                }
            }
        }

        return longestSequence;
    }
}
