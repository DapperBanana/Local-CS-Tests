
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
        string string1 = "karolin";
        string string2 = "kathrin";

        try
        {
            int distance = HammingDistance(string1, string2);
            Console.WriteLine($"The Hamming distance between '{string1}' and '{string2}' is: {distance}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
