
using System;

class Program
{
    static int HammingDistance(string str1, string str2)
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
        string string1 = "abcdefg";
        string string2 = "xbcdeff";

        int distance = HammingDistance(string1, string2);

        Console.WriteLine($"Hamming distance between '{string1}' and '{string2}' is: {distance}");
    }
}
