
using System;

public class VampireNumberChecker
{
    public static void Main()
    {
        int number = 1260; // The number to check
        
        if (IsVampireNumber(number))
        {
            Console.WriteLine($"{number} is a vampire number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a vampire number.");
        }
    }
    
    public static bool IsVampireNumber(int number)
    {
        string numStr = number.ToString();
        int numLength = numStr.Length;
        
        if (numLength % 2 != 0)
        {
            return false;
        }
        
        for (int i = (int)Math.Pow(10, numLength / 2 - 1); i <= Math.Sqrt(number); i++)
        {
            if (number % i != 0)
            {
                continue;
            }
            
            int factor1 = i;
            int factor2 = number / i;
            string factorStr = (factor1.ToString() + factor2.ToString());
            
            char[] numArray = numStr.ToCharArray();
            char[] factorArray = factorStr.ToCharArray();
            
            Array.Sort(numArray);
            Array.Sort(factorArray);
            
            bool isEqual = true;
            for (int j = 0; j < numLength; j++)
            {
                if (numArray[j] != factorArray[j])
                {
                    isEqual = false;
                    break;
                }
            }
            
            if (isEqual)
            {
                return true;
            }
        }
        
        return false;
    }
}
