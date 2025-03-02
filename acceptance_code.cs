
using System;

class IsogramChecker
{
    static bool CheckIsogram(string str)
    {
        // Convert the string to lowercase to ignore case sensitivity
        str = str.ToLower();
        
        // Create a boolean array to keep track of each character
        bool[] visited = new bool[26];
        
        foreach(char c in str)
        {
            // If the character is a letter, check if it has been visited before
            if(char.IsLetter(c))
            {
                int index = c - 'a';
                
                if(visited[index])
                {
                    return false; // Character has already been visited, not an isogram
                }
                visited[index] = true;
            }
        }
        return true; // No repeated characters found, is an isogram
    }

    static void Main()
    {
        string input = "program";
        
        if(CheckIsogram(input))
        {
            Console.WriteLine(input + " is an isogram.");
        }
        else
        {
            Console.WriteLine(input + " is not an isogram.");
        }
    }
}
