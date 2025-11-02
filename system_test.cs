
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int number = 1260; // Change this number to check if a different number is a vampire number

        Console.WriteLine($"Is {number} a vampire number? {IsVampireNumber(number)}");
    }

    static bool IsVampireNumber(int number)
    {
        List<int> digits = number.ToString().Select(c => int.Parse(c.ToString())).ToList();
        
        if (digits.Count % 2 != 0)
        {
            return false;
        }
        
        for (int i = 10; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                int pair = number / i;
                if (IsPermutation(digits, pair.ToString(), (i).ToString()))
                {
                    return true;
                }
            }
        }
        
        return false;
    }

    static bool IsPermutation(List<int> original, string num1, string num2)
    {
        List<int> digits = num1.Select(c => int.Parse(c.ToString())).ToList();
        digits.AddRange(num2.Select(c => int.Parse(c.ToString())));
        
        if (digits.Count != original.Count || digits.Any(d => !original.Contains(d)))
        {
            return false;
        }
        
        foreach (var digit in digits)
        {
            original.Remove(digit);
        }
        
        return original.Count == 0;
    }
}
