
using System;
using System.Collections.Generic;
using System.Linq;

class VampireNumberChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it's a vampire number:");

        int number = int.Parse(Console.ReadLine());

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
        string numberString = number.ToString();
        int numberLength = numberString.Length;

        if (numberLength % 2 != 0)
        {
            return false;
        }

        List<int> digits = numberString.Select(c => int.Parse(c.ToString())).ToList();

        for (int i = 10; i <= Math.Pow(10, numberLength / 2); i++)
        {
            if (number % i == 0)
            {
                int j = number / i;

                if (IsPermutation(i, j, digits))
                {
                    Console.WriteLine($"{i} * {j} = {number}");
                    return true;
                }
            }
        }

        return false;
    }

    static bool IsPermutation(int i, int j, List<int> digits)
    {
        List<int> productDigits = (i.ToString() + j.ToString()).Select(c => int.Parse(c.ToString())).ToList();
        productDigits.Sort();
        digits.Sort();

        return productDigits.SequenceEqual(digits);
    }
}
