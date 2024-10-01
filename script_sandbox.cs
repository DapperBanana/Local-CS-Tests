
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str = "hello world";
        
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        
        foreach(char c in str)
        {
            if(charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        
        foreach(KeyValuePair<char, int> pair in charCount)
        {
            Console.WriteLine("Character: " + pair.Key + ", Count: " + pair.Value);
        }
    }
}
