
using System;

class Program
{
    static void Main()
    {
        string firstString = "1011101";
        string secondString = "1001001";

        int hammingDistance = CalculateHammingDistance(firstString, secondString);

        Console.WriteLine($"The Hamming distance between '{firstString}' and '{secondString}' is: {hammingDistance}");
    }

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
}
