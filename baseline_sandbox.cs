
using System;

class CarmichaelNumberChecker
{
    static bool IsCoprime(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a == 1;
    }

    static bool IsCarmichaelNumber(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int a = 2; a < num; a++)
        {
            if (IsCoprime(a, num) && (long)Math.Pow(a, num - 1) % num != 1)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is a Carmichael number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsCarmichaelNumber(number))
        {
            Console.WriteLine($"{number} is a Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Carmichael number.");
        }
    }
}
