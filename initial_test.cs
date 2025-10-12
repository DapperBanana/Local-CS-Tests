
using System;
using System.Linq;

class Program
{
    static bool IsIsogram(string str)
    {
        str = str.ToLower();
        return str.Distinct().Count() == str.Length;
    }

    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is an isogram:");
        string input = Console.ReadLine();

        if (IsIsogram(input))
        {
            Console.WriteLine($"{input} is an isogram.");
        }
        else
        {
            Console.WriteLine($"{input} is not an isogram.");
        }
    }
}
