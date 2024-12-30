
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int number = 1260;
        if (IsVampireNumber(number))
        {
            Console.WriteLine($"{number} is a vampire number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a vampire number.");
        }
    }

    static bool IsVampireNumber(int number)
    {
        var digits = number.ToString().ToCharArray();
        Array.Sort(digits);

        int numDigits = digits.Length;
        int halfDigits = numDigits / 2;

        for (int i = (int)Math.Pow(10, halfDigits - 1); i < Math.Pow(10, halfDigits); i++)
        {
            if (number % i == 0)
            {
                var otherFactor = number / i;
                if (IsPermutation(i.ToString() + otherFactor.ToString(), digits))
                {
                    return true;
                }
            }
        }

        return false;
    }

    static bool IsPermutation(string s, char[] target)
    {
        var compare = s.ToCharArray();
        Array.Sort(compare);

        return compare.SequenceEqual(target);
    }
}
