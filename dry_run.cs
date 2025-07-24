
using System;

class Program
{
    static int HammingDistance(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            throw new ArgumentException("Strings must be of equal length");
        }

        int distance = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                distance++;
            }
        }

        return distance;
    }

    static void Main()
    {
        string str1 = "karolin";
        string str2 = "kathrin";

        int distance = HammingDistance(str1, str2);

        Console.WriteLine($"The Hamming distance between {str1} and {str2} is: {distance}");
    }
}
