
using System;

public class VampireNumberChecker
{
    public static bool IsVampireNumber(int number)
    {
        string numberString = number.ToString();
        int digits = numberString.Length;
        
        if (digits % 2 != 0)
        {
            return false;
        }
        
        for (int i = 10; i < Math.Pow(10, digits / 2); i++)
        {
            if (number % i == 0)
            {
                int firstFactor = i;
                int secondFactor = number / i;
                string factorString = $"{firstFactor}{secondFactor}";
                
                if (String.Concat(factorString.OrderBy(c => c)) == String.Concat(numberString.OrderBy(c => c)))
                {
                    Console.WriteLine($"{number} is a vampire number. Factors: {firstFactor}, {secondFactor}");
                    return true;
                }
            }
        }
        
        return false;
    }

    static void Main()
    {
        int number = 125460;
        
        if (IsVampireNumber(number))
        {
            Console.WriteLine($"{number} is a vampire number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a vampire number.");
        }
    }
}
