
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> inputList = new List<int>() { 1, 2, 3, 5, 6, 7, 8, 10, 11, 12, 13 };

        List<int> longestSequence = FindLongestConsecutiveSequence(inputList);
        
        Console.WriteLine("Longest consecutive sequence:");
        foreach (int num in longestSequence)
        {
            Console.Write(num + " ");
        }
    }

    static List<int> FindLongestConsecutiveSequence(List<int> inputList)
    {
        inputList.Sort();
        List<int> currentSequence = new List<int>();
        List<int> longestSequence = new List<int>();

        for (int i = 0; i < inputList.Count; i++)
        {
            if (currentSequence.Count == 0 || inputList[i] == currentSequence[currentSequence.Count - 1] + 1)
            {
                currentSequence.Add(inputList[i]);
            }
            else
            {
                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence.Clear();
                    foreach (int num in currentSequence)
                    {
                        longestSequence.Add(num);
                    }
                }
                currentSequence.Clear();
                currentSequence.Add(inputList[i]);
            }
        }

        if (currentSequence.Count > longestSequence.Count)
        {
            longestSequence.Clear();
            foreach (int num in currentSequence)
            {
                longestSequence.Add(num);
            }
        }

        return longestSequence;
    }
}
