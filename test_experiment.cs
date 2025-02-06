
using System;

class Program
{
    static void Main()
    {
        int number = 125460; // Change the value to check for different numbers

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

        if (numberString.Length % 2 != 0)
        {
            return false; // Vampire numbers must have an even number of digits
        }

        for (int i = 10; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                int factor1 = i;
                int factor2 = number / i;

                string f1f2String = factor1.ToString() + factor2.ToString();
                string numberSorted = String.Concat(numberString.OrderBy(c => c));

                if (f1f2String.Equals(numberSorted))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
