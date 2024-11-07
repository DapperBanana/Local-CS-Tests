
using System;

class Program
{
    static void Main()
    {
        string input = "programming";
        
        if (IsIsogram(input))
        {
            Console.WriteLine("The string '{0}' is an isogram.", input);
        }
        else
        {
            Console.WriteLine("The string '{0}' is not an isogram.", input);
        }
    }

    static bool IsIsogram(string input)
    {
        input = input.ToLower();
        
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
