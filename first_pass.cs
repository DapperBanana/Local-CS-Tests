
using System;

class Program
{
    static int CalculateHammingDistance(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            throw new ArgumentException("Input strings must have the same length");
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
        string str1 = "10101010";
        string str2 = "11101110";

        try
        {
            int hammingDistance = CalculateHammingDistance(str1, str2);
            Console.WriteLine($"The Hamming distance between '{str1}' and '{str2}' is: {hammingDistance}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
