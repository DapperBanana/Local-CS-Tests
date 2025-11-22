
using System;

class VampireNumberChecker
{
    public static bool IsVampireNumber(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;

        // Check if the number of digits is even
        if (length % 2 != 0)
        {
            return false;
        }

        for (int i = 10; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                int complement = number / i;

                // Check if the number and its complement have the same number of digits
                if ((i.ToString() + complement.ToString()).Length != length)
                {
                    continue;
                }

                // Check if the number and its complement contain the same digits
                char[] numberChars = numberString.ToCharArray();
                char[] complementChars = (i.ToString() + complement.ToString()).ToCharArray();

                Array.Sort(numberChars);
                Array.Sort(complementChars);

                bool isVampireNumber = true;
                for (int j = 0; j < length; j++)
                {
                    if (numberChars[j] != complementChars[j])
                    {
                        isVampireNumber = false;
                        break;
                    }
                }

                if (isVampireNumber)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is a vampire number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        if (IsVampireNumber(inputNumber))
        {
            Console.WriteLine($"{inputNumber} is a vampire number.");
        }
        else
        {
            Console.WriteLine($"{inputNumber} is not a vampire number.");
        }
    }
}
