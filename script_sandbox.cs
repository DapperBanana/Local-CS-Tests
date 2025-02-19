
using System;

public class VampireNumberChecker
{
    public static bool IsVampireNumber(int number)
    {
        string numberString = number.ToString();
        int numDigits = numberString.Length;
        
        if (numDigits % 2 != 0)
        {
            return false; // Vampire number must have an even number of digits
        }
        
        for (int i = (int)Math.Pow(10, numDigits/2 - 1); i < Math.Sqrt(number) + 1; i++)
        {
            if (number % i == 0)
            {
                int j = number / i;
                string productString = (i.ToString() + j.ToString());
                
                if (String.Concat(numberString.OrderBy(c => c)) == String.Concat(productString.OrderBy(c => c)))
                {
                    return true;
                }
            }
        }
        
        return false;
    }

    public static void Main()
    {
        int input = 1827;
        
        if (IsVampireNumber(input))
        {
            Console.WriteLine(input + " is a vampire number.");
        }
        else
        {
            Console.WriteLine(input + " is not a vampire number.");
        }
    }
}
