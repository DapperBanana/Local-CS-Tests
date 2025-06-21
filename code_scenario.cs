
using System;

class VampireNumberChecker
{
    public static bool IsVampireNumber(int number)
    {
        string numberString = number.ToString();
        int numberLength = numberString.Length;
        
        if (numberLength % 2 != 0)
        {
            return false;
        }
        
        for (int i = 10; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                int factor1 = i;
                int factor2 = number / i;
                string factorString = (factor1.ToString() + factor2.ToString());
                char[] factorChars = factorString.ToCharArray();
                Array.Sort(factorChars);
                
                char[] numberChars = numberString.ToCharArray();
                Array.Sort(numberChars);
                
                if (new string(factorChars) == new string(numberChars))
                {
                    return true;
                }
            }
        }
        
        return false;
    }
    
    static void Main()
    {
        int testNumber = 1260;
        
        if (IsVampireNumber(testNumber))
        {
            Console.WriteLine(testNumber + " is a vampire number.");
        }
        else
        {
            Console.WriteLine(testNumber + " is not a vampire number.");
        }
    }
}
