
using System;

class Program
{
    static int CalculateHammingDistance(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            throw new ArgumentException("Strings must be of equal length");
        }

        int distance = 0;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                distance++;
            }
        }

        return distance;
    }

    static void Main()
    {
        string str1 = "101010";
        string str2 = "111000";

        int hammingDistance = CalculateHammingDistance(str1, str2);

        Console.WriteLine($"Hamming distance between {str1} and {str2} is {hammingDistance}");
    }
}
