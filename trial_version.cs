
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        
        int vowelCount = countVowels(input);
        
        Console.WriteLine("Number of vowels in the string: " + vowelCount);
    }
    
    static int countVowels(string str)
    {
        int count = 0;
        
        foreach(char c in str.ToLower())
        {
            if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }
        
        return count;
    }
}
