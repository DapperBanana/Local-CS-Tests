
using System;

class Program
{
    static void Main()
    {
        string str1 = "karolin";
        string str2 = "kathrin";
        
        int hammingDistance = CalculateHammingDistance(str1, str2);
        
        Console.WriteLine($"The Hamming distance between '{str1}' and '{str2}' is: {hammingDistance}");
    }
    
    static int CalculateHammingDistance(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            throw new ArgumentException("Strings must be of equal length to calculate Hamming distance.");
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
